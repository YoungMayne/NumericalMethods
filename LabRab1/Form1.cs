using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace LabRab1
{
    public partial class Form1 : Form
    {
        private double curX;
        private double maxX;
        private double H;
        private double V;
        private double eps;

        private double coefV;
        private double coefR;
        private double coefL;

        private uint N;

        public Form1()
        {
            InitializeComponent();

            NTextBox.Text       = "0";
            XoTextBox.Text      = "0.0";
            IoTextBox.Text      = "0.0";
            HTextBox.Text       = "0.0";
            VTextBox.Text       = "0.0";
            RTextBox.Text       = "0.0";
            LTextBox.Text       = "0.0";
            XmaxTextBox.Text    = "0.0";
            EpsilonTextBox.Text = "0.0";

            MainGraph.GraphPane.Title       = "";
            MainGraph.GraphPane.XAxis.Title = "X";
            MainGraph.GraphPane.YAxis.Title = "dI/dx";
        }

        private double Function(double x, double v)
        {
            return (coefV - (coefR * v)) / coefL;
        }

        private double Method(double v, double x, double h)
        {
            // Runge - Kutt 4
            double k1 = Function(x, v);
            double k2 = Function(x + h * 0.5, v + h * 0.5 * k1);
            double k3 = Function(x + h * 0.5, v + h * 0.5 * k2);
            double k4 = Function(x + h, v + h * k3);

            return v + (h * 0.1666666666666667 * (k1 + (2.0 * k2) + (2.0 * k3) + k4));
        }

        private void Process()
        {
            PointPairList solutionWithStep     = new PointPairList();
            PointPairList solutionWithHalfStep = new PointPairList();

            List<List<double>> table = new List<List<double>>();
            List<double> row         = new List<double>(11);

            double Vstep = V;
            double Vhalf;
            double Vprev;
            double S;

            uint C1 = 0u;
            uint C2 = 0u;

            // step #0
            table.Add(new List<double>() { 0, 0, curX, Vstep, Vstep, 0, 0, 0, Vstep, 0, 0 });

            // using control
            for(uint i = 1u; (i <= N) && (curX < maxX);)
            {
                // Save previous result
                Vprev = Vstep;

                Vstep = Method(Vprev, curX, H);
                Vhalf = Method(Vprev, curX, H * 0.5);
                Vhalf = Method(Vhalf, curX + (H * 0.5), H * 0.5);

                S = (Vhalf - Vstep) / (Math.Pow(2, 5) - 1);

                if(Math.Abs(S) > eps)
                {
                    H *= 0.5;
                    Vstep = Vprev;
                    C1++;

                    continue;
                }
                else if (Math.Abs(S) <= (eps / (Math.Pow(2, 5))))
                {
                    H *= 2.0;
                    C2++;
                }

                // fill the graph
                solutionWithStep.Add(new PointPair(curX, Vstep));
                solutionWithHalfStep.Add(new PointPair(curX, Vhalf));

                // Create table
                row.Clear();

                // index
                row.Add(i);

                // current step
                row.Add(H);

                // x value
                row.Add(curX);

                // v value with step
                row.Add(Vstep);

                // v value with half step
                row.Add(Vhalf);

                // difference between them
                row.Add(Vstep - Vhalf);

                // S
                row.Add(S);

                // Vi уточ
                row.Add(0);

                // Vi итог
                row.Add(0);

                // number of step doubles
                row.Add(C1);

                //number of step divisions in half
                row.Add(C2);

                // store row
                table.Add(new List<double>(row));

                // Update fields
                i++;
                curX += H;
            }

            // Draw points
            GraphPane pane = MainGraph.GraphPane;
            pane.CurveList.Clear();

            pane.AddCurve("Решение", solutionWithStep, Color.Blue, SymbolType.None);
            pane.AddCurve("Решение с половинным шагом", solutionWithHalfStep, Color.Red, SymbolType.None);

            MainGraph.Hide();
            MainGraph.AxisChange();
            MainGraph.Show();

            // Fill table
            DataGridViewRowCollection rows = MainTable.Rows;
            rows.Clear();

            for(int i = 0; i < table.Count; ++i)
            {
                rows.Add();

                for(int j = 0; j < table[i].Count; ++j)
                {
                    rows[i].Cells[j].Value = table[i][j];
                }
            }
        }

        private bool CheckInput()
        {
            if(!uint.TryParse(NTextBox.Text, out N))
            {
                return false;
            }

            if (!double.TryParse(XoTextBox.Text, out curX))
            {
                return false;
            }

            if (!double.TryParse(IoTextBox.Text, out V))
            {
                return false;
            }

            if (!double.TryParse(HTextBox.Text, out H))
            {
                return false;
            }

            if (!double.TryParse(VTextBox.Text, out coefV))
            {
                return false;
            }

            if (!double.TryParse(RTextBox.Text, out coefR))
            {
                return false;
            }

            if ((!double.TryParse(LTextBox.Text, out coefL)) || (0.0 == coefL))
            {
                return false;
            }

            if (!double.TryParse(XmaxTextBox.Text, out maxX))
            {
                return false;
            }

            if (!double.TryParse(EpsilonTextBox.Text, out eps))
            {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                MessageBox.Show("Ошибка ввода!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process();
        }
    }

}

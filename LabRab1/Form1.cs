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
        Random random;

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

            NTextBox.Text       = "1000";
            XoTextBox.Text      = "3.0";
            IoTextBox.Text      = "2.0";
            HTextBox.Text       = "0.01";
            VTextBox.Text       = "0.0";
            RTextBox.Text       = "2.0";
            LTextBox.Text       = "3.0";
            XmaxTextBox.Text    = "1000.0";
            EpsilonTextBox.Text = "0.001";

            MainGraph.GraphPane.Title       = "";
            MainGraph.GraphPane.XAxis.Title = "X";
            MainGraph.GraphPane.YAxis.Title = "dI/dx";

            minSLabel.Text = "min |S| = "  + 0.ToString();
            maxSLabel.Text = "max |S| = "  + 0.ToString();
            IncLabel.Text  = "Ув. шага = " + 0.ToString();
            DecLabel.Text  = "Ум. шага = " + 0.ToString();

            SolutionType.Items.Add("Решение с постоянным шагом");
            SolutionType.Items.Add("Решение с контролем погрешности");
            SolutionType.SelectedIndex = 0;

            random = new Random();
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

        private void ProcessStatic()
        {
            PointPairList solution = new PointPairList();

            for (int i = 0; (i < N) && (curX < maxX); i++, curX += H)
            {
                V = Method(V, curX, H);
                solution.Add(new PointPair(curX, V));
            }

            // Draw points
            GraphPane pane = MainGraph.GraphPane;

            if (ReloadCheckBox.Checked)
            {
                pane.CurveList.Clear();
            }

            pane.AddCurve("Решение c постоянным шагом", 
                          solution, 
                          Color.FromArgb(random.Next() % 256, 
                                         random.Next() % 256, 
                                         random.Next() % 256), 
                          SymbolType.None);

            MainGraph.AxisChange();
            MainGraph.Refresh();
        }

        private void ProcessDynamic()
        {
            PointPairList solutionWithHalfStep = new PointPairList();

            List<List<double>> table = new List<List<double>>();
            List<double> row         = new List<double>(11);
            List<double> Slist       = new List<double>();
            List<double> Xlist       = new List<double>();

            double Vstep = V;
            double Vhalf;
            double Vprev;
            double S;

            uint C1 = 0u;
            uint C2 = 0u;
            uint totalC1 = 0u;
            uint totalC2 = 0u;

            // step #0
            table.Add(new List<double>() { 0, 0, curX, Vstep, Vstep, 0, 0, 0, 0 });
            solutionWithHalfStep.Add(new PointPair(curX, Vstep));

            // using control
            for (uint i = 1u; (i <= N) && (curX < maxX);)
            {
                // Save previous result
                Vprev = Vstep;

                Vstep = Method(Vprev, curX, H);
                Vhalf = Method(Vprev, curX, H * 0.5);
                Vhalf = Method(Vhalf, curX + (H * 0.5), H * 0.5);

                S = (Vhalf - Vstep) / (Math.Pow(2.0, 5.0) - 1.0);

                if (Math.Abs(S) > eps)
                {
                    H *= 0.5;
                    Vstep = Vprev;
                    C1++;

                    continue;
                }
                else if (Math.Abs(S) <= (eps / (Math.Pow(2.0, 5.0))))
                {
                    H *= 2.0;
                    C2++;                
                }

                Slist.Add(S);
                Xlist.Add(curX);

                // Switch x
                curX += H;

                // fill the graph
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

                // number of step doubles
                row.Add(C1);

                //number of step divisions in half
                row.Add(C2);

                // store row
                table.Add(new List<double>(row));

                // Update fields
                i++;
                totalC1 += C1;
                totalC2 += C2;
                C1 = 0u;
                C2 = 0u;
            }

            // Draw points
            GraphPane pane = MainGraph.GraphPane;

            if (ReloadCheckBox.Checked)
            {
                pane.CurveList.Clear();
            }

            pane.AddCurve("Решение с половинным шагом", 
                          solutionWithHalfStep,
                          Color.FromArgb(random.Next() % 256,
                                         random.Next() % 256,
                                         random.Next() % 256),
                          SymbolType.None);

            MainGraph.AxisChange();
            MainGraph.Refresh();

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

            if((0 == Slist.Count) || (0 == Xlist.Count))
            {
                return;
            }

            // Fill reference
            double minS  = Math.Abs(Slist[0]);
            double maxS  = Math.Abs(Slist[0]);
            double maxSx = Xlist[0];
            double minSx = Xlist[0];

            for(int i = 1; i < Slist.Count; ++i)
            {
                if(Math.Abs(Slist[i]) > maxS)
                {
                    maxS = Math.Abs(Slist[i]);
                    maxSx = Xlist[i];
                }

                if(Math.Abs(Slist[i]) < minS)
                {
                    minS = Math.Abs(Slist[i]);
                    minSx = Xlist[i];
                }
            }

            minSLabel.Text = "min |S| = "  + minS.ToString() + "\nв точке x = " + minSx.ToString();
            maxSLabel.Text = "max |S| = "  + maxS.ToString() + "\nв точке x = " + maxSx.ToString();
            IncLabel.Text  = "Ув. шага = " + totalC2.ToString();
            DecLabel.Text  = "Ум. шага = " + totalC1.ToString();
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

            switch (SolutionType.SelectedIndex)
            {
                case 0:
                    ProcessStatic();
                    break;
                case 1:
                    ProcessDynamic();
                    break;
                default:
                    break;
            }
        }

        private void SolutionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EpsilonLabel.Visible   = (1 == SolutionType.SelectedIndex);
            EpsilonTextBox.Visible = (1 == SolutionType.SelectedIndex);
        }
    }

}

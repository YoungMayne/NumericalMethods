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


namespace NumericalMethods
{
	public partial class MainWindow : Form
	{
		GraphPane pane;

    public Method method = new Method();

		public MainWindow()
		{
			InitializeComponent();

			pane = MainGraph.GraphPane;

			XoTextBox.Text = "0";
			UoTextBox.Text = "1,1";
			U_oTextBox.Text = "0";
            LTextBox.Text = "1,0";
            gTextBox.Text = "10,0";
            StepTextBox.Text = "0,001";
		}

		double ExtractNumber(string str)
		{			
			bool isFloating = false;

			for (int i = 0; i < str.Length; ++i)
			{
				if (!char.IsDigit(str[i]))
				{
					if (str[i] == '.' && i > 0 && !isFloating)
					{
						isFloating = true;
						continue;
					}

					str = str.Remove(i--, 1);
				}
			}
			return str.Length == 0 ? 0.0 : double.Parse(str);
		}

		private void XoTextBox_TextChanged(object sender, EventArgs e)
		{
			double number = ExtractNumber(((TextBox)sender).Text);
		}


		private void MainButton_Click(object sender, EventArgs e)
		{

			method.u1   = double.Parse(UoTextBox.Text);
			method.functions.g    = double.Parse(gTextBox.Text);
			method.x   = double.Parse(XoTextBox.Text);
			method.u2  = double.Parse(U_oTextBox.Text);
			method.functions.L    = double.Parse(LTextBox.Text);
			method.h = double.Parse(StepTextBox.Text);
            method.eps = 0.00001;
            // to do eps
			// Draw
			PointPairList list = new PointPairList();

			for(int i = 0; i < 1000; ++i)
			{
                method.OptimizationStep();
                method.Step();

				list.Add(new PointPair(method.x, method.u1));
			}

			LineItem li = pane.AddCurve("", list, Color.Red, SymbolType.None);

			//MainGraph.Hide();
			MainGraph.AxisChange();
            MainGraph.Invalidate();
            //MainGraph.Show();

		}
	}
}

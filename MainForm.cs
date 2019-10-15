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

		double Xn;
		double Yn;
		double g;
		double L;
		double Uo;
		double step;

		public MainWindow()
		{
			InitializeComponent();

			pane = MainGraph.GraphPane;

			XoTextBox.Text = "0";
			UoTextBox.Text = "0.314";
			U_oTextBox.Text = "0";
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


		double Function1(double x, double v)
		{
			return v;
		}


		double Function2(double x, double v)
		{
			return  -(g / L) * Math.Sin(v);
		}


		void Method(double x, double v, double step)
		{	
			double k1 = Function1(Xn, Yn) * step;
			double m1 = Function2(Xn, Yn) * step;
			double k2 = Function1(Xn + k1 / 2.0, Yn + m1 / 2.0) * step;
			double m2 = Function2(Xn + k1 / 2.0, Yn + m1 / 2.0) * step;
			double k3 = Function1(Xn + k2 / 2.0, Yn + m2 / 2.0) * step;
			double m3 = Function2(Xn + k2 / 2.0, Yn + m2 / 2.0) * step;
			double k4 = Function1(Xn + k3, Yn + m3) * step;
			double m4 = Function2(Xn + k3, Yn + m3) * step;

			Xn = Xn + 1.0 / 6.0 * (k1 + 2.0 * k2 + 2.0 * k3 + k4);
			Yn = Yn + 1.0 / 6.0 * (m1 + 2.0 * m2 + 2.0 * m3 + m4);
		}


		private void XoTextBox_TextChanged(object sender, EventArgs e)
		{
			double number = ExtractNumber(((TextBox)sender).Text);
		}


		private void MainButton_Click(object sender, EventArgs e)
		{
			Uo   = ExtractNumber(UoTextBox.Text);
			g    = ExtractNumber(gTextBox.Text);
			Xn   = ExtractNumber(XoTextBox.Text);
			Yn  = ExtractNumber(U_oTextBox.Text);
			L    = ExtractNumber(LTextBox.Text);
			step = ExtractNumber(StepTextBox.Text);			

			// Draw
			PointPairList list = new PointPairList();
			list.Add(new PointPair(Xn, Yn));

			for(int i = 0; i < 100; ++i)
			{
				Method(Xn, Yn, step);

				list.Add(new PointPair(Xn, Yn));
			}

			LineItem li = pane.AddCurve("", list, Color.Red, SymbolType.None);

			MainGraph.Hide();
			MainGraph.AxisChange();
			MainGraph.Show();
		}
	}
}

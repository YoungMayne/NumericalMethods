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
	public enum MethodType
	{
		RK2,
		RK3,
		RK4
	}

	public partial class MainWindow : Form
	{
		GraphPane graphPane;
		MethodType method;

		private const string min_step = "0.1";

		double x;
		double v;

		public MainWindow()
		{
			InitializeComponent();

			graphPane = MainGraph.GraphPane;

			MethodTextBox.BorderStyle = BorderStyle.None;

			graphPane.XAxis.Type = AxisType.Linear;
			graphPane.XAxis.Title = "X";
			graphPane.YAxis.Title = "U";
			graphPane.Title = "";

			StepInputBox.Text = min_step;

			SelectMethodBox.SelectedItem = SelectMethodBox.Items[0];
			method = MethodType.RK2;

			v = Math.PI / 10.0;

			DrawScene();
		}


		private double Formula(double x, double v)
		{
			return -98.0 * Math.Sin(v);
		}


		private void DrawScene()
		{
			graphPane.CurveList.Clear();
			graphPane.AddCurve("Sine Curve", CreateField(), Color.Purple, SymbolType.None);


			MainGraph.Hide();
			MainGraph.AxisChange();
			MainGraph.Show();
		}


		private PointPairList CreateField()
		{
			PointPairList list = null;

			switch (method)
			{
				case MethodType.RK2:
					list = Runge_Kutt2();
					break;
				case MethodType.RK3:
					break;
				case MethodType.RK4:
					break;
				default:
					break;
			}

			return list;
		}


		private PointPairList Runge_Kutt2()
		{
			PointPairList list = new PointPairList();

			double V = v;
			double step = double.Parse(StepInputBox.Text);

			step = step == 0 ? 0.1 : step;

			for(double X = 0; X < 1000; X += step)
			{
				PointPair pair = new PointPair(X, V);
				list.Add(pair);

				V = Formula(X, V);
			}


			return list;
		}

		private void SelectMethodBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox box = (ComboBox)sender;

			switch ((string)box.SelectedItem)
			{
				case "Рунге-Кутта 2го порядка":
					method = MethodType.RK2;
					break;
				case "Рунге-Кутта 3го порядка":
					method = MethodType.RK3;
					break;
				case "Рунге-Кутта 4го порядка":
					method = MethodType.RK4;
					break;
				default:
					break;
			}

			DrawScene();
		}


		private void StepInputBox_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			for (int i = 0; i < box.Text.Length; ++i)
			{
				if (!char.IsDigit(box.Text[i]))
				{
					if (box.Text[i] == '.' && i > 0)
					{
						continue;
					}

					box.Text = box.Text.Remove(i--, 1);
				}
			}

			if(box.Text.Length == 0)
			{
				box.Text = min_step;
			}

			DrawScene();
		}
	}
}

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
			UoTextBox.Text = "1.1";
			U_oTextBox.Text = "0";
			LTextBox.Text = "1.0";
			gTextBox.Text = "10.0";
			StepTextBox.Text = "0.001";
			EpsilonTextBox.Text = "0.01";
			TTextBox.Text = "0.01";

			DoubleStepLabel.Text = "0";
			DividesLabel.Text = "0";
			MaxStepLabel.Text = "0";
			MinStepLabel.Text = "0";
			BiggestErrorLabel.Text = "0";
			DotLabel.Text = "0";
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

			method.u1 = double.Parse(UoTextBox.Text);
			method.functions.g = double.Parse(gTextBox.Text);
			method.x = double.Parse(XoTextBox.Text);
			method.u2 = double.Parse(U_oTextBox.Text);
			method.functions.L = double.Parse(LTextBox.Text);
			method.h = double.Parse(StepTextBox.Text);
			method.eps = double.Parse(EpsilonTextBox.Text);
			// Draw
			PointPairList list = new PointPairList();

			List<List<double>> table = new List<List<double>>();

			int doubles = 0;
			int divides = 0;

			for (int i = 0; i < 1000; ++i)
			{
				table.Add(new List<double>());
				table.Last().Add(i);

				method.OptimizationStep(ref table, ref doubles, ref divides);
				method.Step();

				list.Add(new PointPair(method.x, method.u1));
			}

			LineItem li = pane.AddCurve("", list, Color.Red, SymbolType.None);

			// Table creating

			DataGridViewRowCollection rows = Table.Rows;

			rows.Clear();

			for (int i = 0; i < table.Count; ++i)
			{
				rows.Add();
				for (int j = 0; j < table[i].Count; ++j)
				{
					rows[i].Cells[j].Value = table[i][j];
				}
			}


			// Calculate max and min step
			double maxStep = (double)rows[0].Cells[1].Value;
			double minStep = (double)rows[0].Cells[1].Value;
			for (int i = 1; i < table.Count; ++i)
			{
				if((double)rows[i].Cells[1].Value > maxStep)
				{
					maxStep = (double)rows[i].Cells[1].Value;
				}
				else if((double)rows[i].Cells[1].Value < minStep)
				{
					minStep = (double)rows[i].Cells[1].Value;
				}
			}

			MaxStepLabel.Text = maxStep.ToString();
			MinStepLabel.Text = minStep.ToString();
			DoubleStepLabel.Text = doubles.ToString();
			DividesLabel.Text = divides.ToString();

			//MainGraph.Hide();
			MainGraph.AxisChange();
			MainGraph.Invalidate();
			//MainGraph.Show();

		}
	}
}

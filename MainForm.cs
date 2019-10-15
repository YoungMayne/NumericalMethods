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
		Method method;

		public MainWindow()
		{
			InitializeComponent();

			MethodComboBox.Items.Add("Эйлера 1го порядка");
			MethodComboBox.Items.Add("Рунге-Кутта 2го порядка");
			MethodComboBox.SelectedIndex = 0;

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


		private void MethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox box = (ComboBox)sender;

			switch (box.SelectedIndex)
			{
				case 0:
					method = new Euler();
					break;
				case 1:
					method = new RK2();
					break;
				default:
					break;
			}
		}


		private void XoTextBox_TextChanged(object sender, EventArgs e)
		{
			double number = ExtractNumber(((TextBox)sender).Text);
		}
	}
}

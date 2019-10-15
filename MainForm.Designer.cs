namespace NumericalMethods
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TabControl = new System.Windows.Forms.TabControl();
			this.Page1 = new System.Windows.Forms.TabPage();
			this.MainButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.LTextBox = new System.Windows.Forms.TextBox();
			this.gTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.U_oTextBox = new System.Windows.Forms.TextBox();
			this.UoTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.XoTextBox = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.MainGraph = new ZedGraph.ZedGraphControl();
			this.Page2 = new System.Windows.Forms.TabPage();
			this.StepTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TabControl.SuspendLayout();
			this.Page1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.Page1);
			this.TabControl.Controls.Add(this.Page2);
			this.TabControl.ItemSize = new System.Drawing.Size(20, 15);
			this.TabControl.Location = new System.Drawing.Point(0, 0);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(1300, 700);
			this.TabControl.TabIndex = 0;
			// 
			// Page1
			// 
			this.Page1.Controls.Add(this.label6);
			this.Page1.Controls.Add(this.StepTextBox);
			this.Page1.Controls.Add(this.MainButton);
			this.Page1.Controls.Add(this.label5);
			this.Page1.Controls.Add(this.LTextBox);
			this.Page1.Controls.Add(this.gTextBox);
			this.Page1.Controls.Add(this.label4);
			this.Page1.Controls.Add(this.label3);
			this.Page1.Controls.Add(this.label2);
			this.Page1.Controls.Add(this.U_oTextBox);
			this.Page1.Controls.Add(this.UoTextBox);
			this.Page1.Controls.Add(this.label1);
			this.Page1.Controls.Add(this.XoTextBox);
			this.Page1.Controls.Add(this.dataGridView1);
			this.Page1.Controls.Add(this.MainGraph);
			this.Page1.Location = new System.Drawing.Point(4, 19);
			this.Page1.Name = "Page1";
			this.Page1.Padding = new System.Windows.Forms.Padding(3);
			this.Page1.Size = new System.Drawing.Size(1292, 677);
			this.Page1.TabIndex = 0;
			this.Page1.Text = "Задача";
			this.Page1.UseVisualStyleBackColor = true;
			// 
			// MainButton
			// 
			this.MainButton.Location = new System.Drawing.Point(1170, 68);
			this.MainButton.Name = "MainButton";
			this.MainButton.Size = new System.Drawing.Size(94, 50);
			this.MainButton.TabIndex = 14;
			this.MainButton.Text = "Вычислить";
			this.MainButton.UseVisualStyleBackColor = true;
			this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(360, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "L";
			// 
			// LTextBox
			// 
			this.LTextBox.Location = new System.Drawing.Point(306, 84);
			this.LTextBox.Name = "LTextBox";
			this.LTextBox.Size = new System.Drawing.Size(121, 20);
			this.LTextBox.TabIndex = 12;
			// 
			// gTextBox
			// 
			this.gTextBox.Location = new System.Drawing.Point(158, 30);
			this.gTextBox.Name = "gTextBox";
			this.gTextBox.Size = new System.Drawing.Size(121, 20);
			this.gTextBox.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(214, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "g";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(208, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "U\'o";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Uo";
			// 
			// U_oTextBox
			// 
			this.U_oTextBox.Location = new System.Drawing.Point(158, 84);
			this.U_oTextBox.Name = "U_oTextBox";
			this.U_oTextBox.Size = new System.Drawing.Size(121, 20);
			this.U_oTextBox.TabIndex = 7;
			// 
			// UoTextBox
			// 
			this.UoTextBox.Location = new System.Drawing.Point(8, 30);
			this.UoTextBox.Name = "UoTextBox";
			this.UoTextBox.Size = new System.Drawing.Size(121, 20);
			this.UoTextBox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Xo";
			// 
			// XoTextBox
			// 
			this.XoTextBox.Location = new System.Drawing.Point(8, 84);
			this.XoTextBox.Name = "XoTextBox";
			this.XoTextBox.Size = new System.Drawing.Size(121, 20);
			this.XoTextBox.TabIndex = 4;
			this.XoTextBox.TextChanged += new System.EventHandler(this.XoTextBox_TextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(8, 128);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(625, 498);
			this.dataGridView1.TabIndex = 1;
			// 
			// MainGraph
			// 
			this.MainGraph.IsShowPointValues = false;
			this.MainGraph.Location = new System.Drawing.Point(639, 128);
			this.MainGraph.Name = "MainGraph";
			this.MainGraph.PointValueFormat = "G";
			this.MainGraph.Size = new System.Drawing.Size(625, 498);
			this.MainGraph.TabIndex = 0;
			// 
			// Page2
			// 
			this.Page2.Location = new System.Drawing.Point(4, 19);
			this.Page2.Name = "Page2";
			this.Page2.Padding = new System.Windows.Forms.Padding(3);
			this.Page2.Size = new System.Drawing.Size(1292, 677);
			this.Page2.TabIndex = 2;
			this.Page2.Text = "Справка";
			this.Page2.UseVisualStyleBackColor = true;
			// 
			// StepTextBox
			// 
			this.StepTextBox.Location = new System.Drawing.Point(306, 30);
			this.StepTextBox.Name = "StepTextBox";
			this.StepTextBox.Size = new System.Drawing.Size(121, 20);
			this.StepTextBox.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(355, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Шаг";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(1280, 657);
			this.Controls.Add(this.TabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainWindow";
			this.Text = "NumericalMethods";
			this.TabControl.ResumeLayout(false);
			this.Page1.ResumeLayout(false);
			this.Page1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage Page1;
		private System.Windows.Forms.TabPage Page2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ZedGraph.ZedGraphControl MainGraph;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox U_oTextBox;
		private System.Windows.Forms.TextBox UoTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox XoTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox LTextBox;
		private System.Windows.Forms.TextBox gTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button MainButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox StepTextBox;
	}
}


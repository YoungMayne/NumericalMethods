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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.EpsilonTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.StepTextBox = new System.Windows.Forms.TextBox();
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
			this.Table = new System.Windows.Forms.DataGridView();
			this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vihalf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vinice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vinice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vitarg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Viitog = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ui = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.module = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainGraph = new ZedGraph.ZedGraphControl();
			this.Page2 = new System.Windows.Forms.TabPage();
			this.DotLabel = new System.Windows.Forms.Label();
			this.BiggestErrorLabel = new System.Windows.Forms.Label();
			this.MinStepLabel = new System.Windows.Forms.Label();
			this.MaxStepLabel = new System.Windows.Forms.Label();
			this.DividesLabel = new System.Windows.Forms.Label();
			this.DoubleStepLabel = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.TabControl.SuspendLayout();
			this.Page1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
			this.Page2.SuspendLayout();
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
			this.Page1.Controls.Add(this.pictureBox1);
			this.Page1.Controls.Add(this.label8);
			this.Page1.Controls.Add(this.EpsilonTextBox);
			this.Page1.Controls.Add(this.label7);
			this.Page1.Controls.Add(this.TTextBox);
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
			this.Page1.Controls.Add(this.Table);
			this.Page1.Controls.Add(this.MainGraph);
			this.Page1.Location = new System.Drawing.Point(4, 19);
			this.Page1.Name = "Page1";
			this.Page1.Padding = new System.Windows.Forms.Padding(3);
			this.Page1.Size = new System.Drawing.Size(1292, 677);
			this.Page1.TabIndex = 0;
			this.Page1.Text = "Задача";
			this.Page1.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::NumericalMethods.Properties.Resources.Formula;
			this.pictureBox1.Location = new System.Drawing.Point(17, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(202, 61);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(772, 73);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Epsilon";
			// 
			// EpsilonTextBox
			// 
			this.EpsilonTextBox.Location = new System.Drawing.Point(733, 89);
			this.EpsilonTextBox.Name = "EpsilonTextBox";
			this.EpsilonTextBox.Size = new System.Drawing.Size(121, 20);
			this.EpsilonTextBox.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(790, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(10, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "t";
			// 
			// TTextBox
			// 
			this.TTextBox.Location = new System.Drawing.Point(733, 35);
			this.TTextBox.Name = "TTextBox";
			this.TTextBox.Size = new System.Drawing.Size(121, 20);
			this.TTextBox.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(631, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Шаг";
			// 
			// StepTextBox
			// 
			this.StepTextBox.Location = new System.Drawing.Point(582, 35);
			this.StepTextBox.Name = "StepTextBox";
			this.StepTextBox.Size = new System.Drawing.Size(121, 20);
			this.StepTextBox.TabIndex = 15;
			// 
			// MainButton
			// 
			this.MainButton.Location = new System.Drawing.Point(1170, 46);
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
			this.label5.Location = new System.Drawing.Point(636, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "L";
			// 
			// LTextBox
			// 
			this.LTextBox.Location = new System.Drawing.Point(582, 89);
			this.LTextBox.Name = "LTextBox";
			this.LTextBox.Size = new System.Drawing.Size(121, 20);
			this.LTextBox.TabIndex = 12;
			// 
			// gTextBox
			// 
			this.gTextBox.Location = new System.Drawing.Point(434, 35);
			this.gTextBox.Name = "gTextBox";
			this.gTextBox.Size = new System.Drawing.Size(121, 20);
			this.gTextBox.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(490, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "g";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(484, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "U\'o";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(334, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Uo";
			// 
			// U_oTextBox
			// 
			this.U_oTextBox.Location = new System.Drawing.Point(434, 89);
			this.U_oTextBox.Name = "U_oTextBox";
			this.U_oTextBox.Size = new System.Drawing.Size(121, 20);
			this.U_oTextBox.TabIndex = 7;
			// 
			// UoTextBox
			// 
			this.UoTextBox.Location = new System.Drawing.Point(284, 35);
			this.UoTextBox.Name = "UoTextBox";
			this.UoTextBox.Size = new System.Drawing.Size(121, 20);
			this.UoTextBox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(334, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Xo";
			// 
			// XoTextBox
			// 
			this.XoTextBox.Location = new System.Drawing.Point(284, 89);
			this.XoTextBox.Name = "XoTextBox";
			this.XoTextBox.Size = new System.Drawing.Size(121, 20);
			this.XoTextBox.TabIndex = 4;
			this.XoTextBox.TextChanged += new System.EventHandler(this.XoTextBox_TextChanged);
			// 
			// Table
			// 
			this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Hi,
            this.Xi,
            this.Vi,
            this.Vihalf,
            this.Vinice,
            this.Vinice2,
            this.S,
            this.Vitarg,
            this.Viitog,
            this.Ui,
            this.module});
			this.Table.Location = new System.Drawing.Point(-42, 128);
			this.Table.Name = "Table";
			this.Table.Size = new System.Drawing.Size(625, 498);
			this.Table.TabIndex = 1;
			// 
			// i
			// 
			this.i.HeaderText = "i";
			this.i.Name = "i";
			this.i.Width = 34;
			// 
			// Hi
			// 
			this.Hi.HeaderText = "Hi";
			this.Hi.Name = "Hi";
			this.Hi.Width = 42;
			// 
			// Xi
			// 
			this.Xi.HeaderText = "Xi";
			this.Xi.Name = "Xi";
			this.Xi.Width = 41;
			// 
			// Vi
			// 
			this.Vi.HeaderText = "Vi";
			this.Vi.Name = "Vi";
			this.Vi.Width = 41;
			// 
			// Vihalf
			// 
			this.Vihalf.HeaderText = "Vi+1/2";
			this.Vihalf.Name = "Vihalf";
			this.Vihalf.Width = 64;
			// 
			// Vinice
			// 
			this.Vinice.HeaderText = "Vi удв.";
			this.Vinice.Name = "Vinice";
			this.Vinice.Width = 64;
			// 
			// Vinice2
			// 
			this.Vinice2.HeaderText = "Vi удв. - Vi";
			this.Vinice2.Name = "Vinice2";
			this.Vinice2.Width = 82;
			// 
			// S
			// 
			this.S.HeaderText = "S";
			this.S.Name = "S";
			this.S.Width = 39;
			// 
			// Vitarg
			// 
			this.Vitarg.HeaderText = "Vi уточ.";
			this.Vitarg.Name = "Vitarg";
			this.Vitarg.Width = 68;
			// 
			// Viitog
			// 
			this.Viitog.HeaderText = "Vi итог.";
			this.Viitog.Name = "Viitog";
			this.Viitog.Width = 69;
			// 
			// Ui
			// 
			this.Ui.HeaderText = "Ui";
			this.Ui.Name = "Ui";
			this.Ui.Width = 42;
			// 
			// module
			// 
			this.module.HeaderText = "|Ui - Vi итог|";
			this.module.Name = "module";
			this.module.Width = 89;
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
			this.Page2.Controls.Add(this.DotLabel);
			this.Page2.Controls.Add(this.BiggestErrorLabel);
			this.Page2.Controls.Add(this.MinStepLabel);
			this.Page2.Controls.Add(this.MaxStepLabel);
			this.Page2.Controls.Add(this.DividesLabel);
			this.Page2.Controls.Add(this.DoubleStepLabel);
			this.Page2.Controls.Add(this.label14);
			this.Page2.Controls.Add(this.label13);
			this.Page2.Controls.Add(this.label12);
			this.Page2.Controls.Add(this.label11);
			this.Page2.Controls.Add(this.label10);
			this.Page2.Controls.Add(this.label9);
			this.Page2.Location = new System.Drawing.Point(4, 19);
			this.Page2.Name = "Page2";
			this.Page2.Padding = new System.Windows.Forms.Padding(3);
			this.Page2.Size = new System.Drawing.Size(1292, 677);
			this.Page2.TabIndex = 2;
			this.Page2.Text = "Справка";
			this.Page2.UseVisualStyleBackColor = true;
			// 
			// DotLabel
			// 
			this.DotLabel.AutoSize = true;
			this.DotLabel.Location = new System.Drawing.Point(134, 128);
			this.DotLabel.Name = "DotLabel";
			this.DotLabel.Size = new System.Drawing.Size(0, 13);
			this.DotLabel.TabIndex = 11;
			// 
			// BiggestErrorLabel
			// 
			this.BiggestErrorLabel.AutoSize = true;
			this.BiggestErrorLabel.Location = new System.Drawing.Point(134, 105);
			this.BiggestErrorLabel.Name = "BiggestErrorLabel";
			this.BiggestErrorLabel.Size = new System.Drawing.Size(0, 13);
			this.BiggestErrorLabel.TabIndex = 10;
			// 
			// MinStepLabel
			// 
			this.MinStepLabel.AutoSize = true;
			this.MinStepLabel.Location = new System.Drawing.Point(134, 81);
			this.MinStepLabel.Name = "MinStepLabel";
			this.MinStepLabel.Size = new System.Drawing.Size(0, 13);
			this.MinStepLabel.TabIndex = 9;
			// 
			// MaxStepLabel
			// 
			this.MaxStepLabel.AutoSize = true;
			this.MaxStepLabel.Location = new System.Drawing.Point(134, 59);
			this.MaxStepLabel.Name = "MaxStepLabel";
			this.MaxStepLabel.Size = new System.Drawing.Size(0, 13);
			this.MaxStepLabel.TabIndex = 8;
			// 
			// DividesLabel
			// 
			this.DividesLabel.AutoSize = true;
			this.DividesLabel.Location = new System.Drawing.Point(134, 37);
			this.DividesLabel.Name = "DividesLabel";
			this.DividesLabel.Size = new System.Drawing.Size(0, 13);
			this.DividesLabel.TabIndex = 7;
			// 
			// DoubleStepLabel
			// 
			this.DoubleStepLabel.AutoSize = true;
			this.DoubleStepLabel.Location = new System.Drawing.Point(134, 14);
			this.DoubleStepLabel.Name = "DoubleStepLabel";
			this.DoubleStepLabel.Size = new System.Drawing.Size(0, 13);
			this.DoubleStepLabel.TabIndex = 6;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(84, 128);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(44, 13);
			this.label14.TabIndex = 5;
			this.label14.Text = "в точке";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 105);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(125, 13);
			this.label13.TabIndex = 4;
			this.label13.Text = "Максимальная ошибка";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 81);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(102, 13);
			this.label12.TabIndex = 3;
			this.label12.Text = "Минимальный шаг";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 59);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(108, 13);
			this.label11.TabIndex = 2;
			this.label11.Text = "Максимальный шаг";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 37);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(84, 13);
			this.label10.TabIndex = 1;
			this.label10.Text = "Число делений";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Число удвоений";
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
			this.Page2.ResumeLayout(false);
			this.Page2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage Page1;
		private System.Windows.Forms.TabPage Page2;
		private System.Windows.Forms.DataGridView Table;
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
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn i;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vihalf;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vinice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vinice2;
		private System.Windows.Forms.DataGridViewTextBoxColumn S;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vitarg;
		private System.Windows.Forms.DataGridViewTextBoxColumn Viitog;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ui;
		private System.Windows.Forms.DataGridViewTextBoxColumn module;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox EpsilonTextBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label DotLabel;
		private System.Windows.Forms.Label BiggestErrorLabel;
		private System.Windows.Forms.Label MinStepLabel;
		private System.Windows.Forms.Label MaxStepLabel;
		private System.Windows.Forms.Label DividesLabel;
		private System.Windows.Forms.Label DoubleStepLabel;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
	}
}


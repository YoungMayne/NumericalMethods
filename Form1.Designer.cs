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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.MainGraph = new ZedGraph.ZedGraphControl();
			this.Image = new System.Windows.Forms.PictureBox();
			this.SelectMethodBox = new System.Windows.Forms.ComboBox();
			this.MethodTextBox = new System.Windows.Forms.Label();
			this.SelectStepTextBox = new System.Windows.Forms.Label();
			this.StepInputBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
			this.SuspendLayout();
			// 
			// MainGraph
			// 
			this.MainGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.MainGraph.IsShowPointValues = false;
			this.MainGraph.Location = new System.Drawing.Point(354, 61);
			this.MainGraph.Name = "MainGraph";
			this.MainGraph.PointValueFormat = "G";
			this.MainGraph.Size = new System.Drawing.Size(911, 579);
			this.MainGraph.TabIndex = 0;
			// 
			// Image
			// 
			this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
			this.Image.Location = new System.Drawing.Point(45, 61);
			this.Image.Name = "Image";
			this.Image.Size = new System.Drawing.Size(210, 57);
			this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Image.TabIndex = 1;
			this.Image.TabStop = false;
			// 
			// SelectMethodBox
			// 
			this.SelectMethodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SelectMethodBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SelectMethodBox.FormattingEnabled = true;
			this.SelectMethodBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.SelectMethodBox.Items.AddRange(new object[] {
            "Рунге-Кутта 2го порядка",
            "Рунге-Кутта 3го порядка",
            "Рунге-Кутта 4го порядка"});
			this.SelectMethodBox.Location = new System.Drawing.Point(106, 163);
			this.SelectMethodBox.Name = "SelectMethodBox";
			this.SelectMethodBox.Size = new System.Drawing.Size(149, 21);
			this.SelectMethodBox.TabIndex = 3;
			this.SelectMethodBox.SelectedIndexChanged += new System.EventHandler(this.SelectMethodBox_SelectedIndexChanged);
			// 
			// MethodTextBox
			// 
			this.MethodTextBox.AutoSize = true;
			this.MethodTextBox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MethodTextBox.ForeColor = System.Drawing.Color.Gainsboro;
			this.MethodTextBox.Location = new System.Drawing.Point(41, 160);
			this.MethodTextBox.Name = "MethodTextBox";
			this.MethodTextBox.Size = new System.Drawing.Size(68, 23);
			this.MethodTextBox.TabIndex = 4;
			this.MethodTextBox.Text = "Метод";
			// 
			// SelectStepTextBox
			// 
			this.SelectStepTextBox.AutoSize = true;
			this.SelectStepTextBox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectStepTextBox.ForeColor = System.Drawing.Color.Gainsboro;
			this.SelectStepTextBox.Location = new System.Drawing.Point(41, 200);
			this.SelectStepTextBox.Name = "SelectStepTextBox";
			this.SelectStepTextBox.Size = new System.Drawing.Size(45, 23);
			this.SelectStepTextBox.TabIndex = 5;
			this.SelectStepTextBox.Text = "Шаг";
			// 
			// StepInputBox
			// 
			this.StepInputBox.Location = new System.Drawing.Point(107, 202);
			this.StepInputBox.Name = "StepInputBox";
			this.StepInputBox.Size = new System.Drawing.Size(148, 20);
			this.StepInputBox.TabIndex = 6;
			this.StepInputBox.TextChanged += new System.EventHandler(this.StepInputBox_TextChanged);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(1277, 652);
			this.Controls.Add(this.StepInputBox);
			this.Controls.Add(this.SelectStepTextBox);
			this.Controls.Add(this.MethodTextBox);
			this.Controls.Add(this.SelectMethodBox);
			this.Controls.Add(this.Image);
			this.Controls.Add(this.MainGraph);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainWindow";
			this.Text = "NumericalMethods";
			((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ZedGraph.ZedGraphControl MainGraph;
		private System.Windows.Forms.PictureBox Image;
		private System.Windows.Forms.ComboBox SelectMethodBox;
		private System.Windows.Forms.Label MethodTextBox;
		private System.Windows.Forms.Label SelectStepTextBox;
		private System.Windows.Forms.TextBox StepInputBox;
	}
}


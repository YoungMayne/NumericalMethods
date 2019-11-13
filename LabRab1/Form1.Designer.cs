namespace LabRab1
{
    partial class Form1
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
            this.MainGraph = new ZedGraph.ZedGraphControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.IncLabel = new System.Windows.Forms.Label();
            this.DecLabel = new System.Windows.Forms.Label();
            this.minSLabel = new System.Windows.Forms.Label();
            this.maxSLabel = new System.Windows.Forms.Label();
            this.HTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EpsilonTextBox = new System.Windows.Forms.TextBox();
            this.EpsilonLabel = new System.Windows.Forms.Label();
            this.XmaxTextBox = new System.Windows.Forms.TextBox();
            this.XmaxLabel = new System.Windows.Forms.Label();
            this.LTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.XoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReloadCheckBox = new System.Windows.Forms.CheckBox();
            this.SolutionType = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGraph
            // 
            this.MainGraph.IsShowPointValues = false;
            this.MainGraph.Location = new System.Drawing.Point(-4, -16);
            this.MainGraph.Name = "MainGraph";
            this.MainGraph.PointValueFormat = "G";
            this.MainGraph.Size = new System.Drawing.Size(811, 641);
            this.MainGraph.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(517, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 647);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MainGraph);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "График";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MainTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблица";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainTable
            // 
            this.MainTable.AllowUserToAddRows = false;
            this.MainTable.AllowUserToDeleteRows = false;
            this.MainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainTable.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.MainTable.Location = new System.Drawing.Point(-21, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.ReadOnly = true;
            this.MainTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.MainTable.Size = new System.Drawing.Size(781, 625);
            this.MainTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hi-1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Xi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Vi удв.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vi -Vi удв.";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "S";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Vi уточ.";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Vi итог.";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ум. шага";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ув. шага";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(-2, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1332, 692);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage3.Controls.Add(this.SolutionType);
            this.tabPage3.Controls.Add(this.ReloadCheckBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.IncLabel);
            this.tabPage3.Controls.Add(this.DecLabel);
            this.tabPage3.Controls.Add(this.minSLabel);
            this.tabPage3.Controls.Add(this.maxSLabel);
            this.tabPage3.Controls.Add(this.HTextBox);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.EpsilonTextBox);
            this.tabPage3.Controls.Add(this.EpsilonLabel);
            this.tabPage3.Controls.Add(this.XmaxTextBox);
            this.tabPage3.Controls.Add(this.XmaxLabel);
            this.tabPage3.Controls.Add(this.LTextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.RTextBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.VTextBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.IoTextBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.XoTextBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.NTextBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1324, 666);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Задача";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(145, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "Справка";
            // 
            // IncLabel
            // 
            this.IncLabel.AutoSize = true;
            this.IncLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncLabel.Location = new System.Drawing.Point(15, 475);
            this.IncLabel.Name = "IncLabel";
            this.IncLabel.Size = new System.Drawing.Size(118, 29);
            this.IncLabel.TabIndex = 25;
            this.IncLabel.Text = "Ув. шага = ";
            // 
            // DecLabel
            // 
            this.DecLabel.AutoSize = true;
            this.DecLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecLabel.Location = new System.Drawing.Point(15, 443);
            this.DecLabel.Name = "DecLabel";
            this.DecLabel.Size = new System.Drawing.Size(122, 29);
            this.DecLabel.TabIndex = 24;
            this.DecLabel.Text = "Ум. шага = ";
            // 
            // minSLabel
            // 
            this.minSLabel.AutoSize = true;
            this.minSLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minSLabel.Location = new System.Drawing.Point(15, 385);
            this.minSLabel.Name = "minSLabel";
            this.minSLabel.Size = new System.Drawing.Size(108, 29);
            this.minSLabel.TabIndex = 23;
            this.minSLabel.Text = "min |S| = ";
            // 
            // maxSLabel
            // 
            this.maxSLabel.AutoSize = true;
            this.maxSLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxSLabel.Location = new System.Drawing.Point(15, 322);
            this.maxSLabel.Name = "maxSLabel";
            this.maxSLabel.Size = new System.Drawing.Size(114, 29);
            this.maxSLabel.TabIndex = 22;
            this.maxSLabel.Text = "max |S| = ";
            // 
            // HTextBox
            // 
            this.HTextBox.Location = new System.Drawing.Point(68, 212);
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.Size = new System.Drawing.Size(54, 20);
            this.HTextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "H = ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LabRab1.Properties.Resources.FormulaLB1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(496, 92);
            this.button1.TabIndex = 18;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EpsilonTextBox
            // 
            this.EpsilonTextBox.Location = new System.Drawing.Point(380, 140);
            this.EpsilonTextBox.Name = "EpsilonTextBox";
            this.EpsilonTextBox.Size = new System.Drawing.Size(54, 20);
            this.EpsilonTextBox.TabIndex = 17;
            // 
            // EpsilonLabel
            // 
            this.EpsilonLabel.AutoSize = true;
            this.EpsilonLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EpsilonLabel.Location = new System.Drawing.Point(275, 133);
            this.EpsilonLabel.Name = "EpsilonLabel";
            this.EpsilonLabel.Size = new System.Drawing.Size(98, 29);
            this.EpsilonLabel.TabIndex = 16;
            this.EpsilonLabel.Text = "Epsilon =";
            // 
            // XmaxTextBox
            // 
            this.XmaxTextBox.Location = new System.Drawing.Point(209, 212);
            this.XmaxTextBox.Name = "XmaxTextBox";
            this.XmaxTextBox.Size = new System.Drawing.Size(54, 20);
            this.XmaxTextBox.TabIndex = 15;
            // 
            // XmaxLabel
            // 
            this.XmaxLabel.AutoSize = true;
            this.XmaxLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XmaxLabel.Location = new System.Drawing.Point(145, 206);
            this.XmaxLabel.Name = "XmaxLabel";
            this.XmaxLabel.Size = new System.Drawing.Size(62, 29);
            this.XmaxLabel.TabIndex = 14;
            this.XmaxLabel.Text = "Xn  =";
            // 
            // LTextBox
            // 
            this.LTextBox.Location = new System.Drawing.Point(192, 177);
            this.LTextBox.Name = "LTextBox";
            this.LTextBox.Size = new System.Drawing.Size(54, 20);
            this.LTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(145, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "L = ";
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(192, 139);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(54, 20);
            this.RTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(145, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "R = ";
            // 
            // VTextBox
            // 
            this.VTextBox.Location = new System.Drawing.Point(192, 103);
            this.VTextBox.Name = "VTextBox";
            this.VTextBox.Size = new System.Drawing.Size(54, 20);
            this.VTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(145, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "V = ";
            // 
            // IoTextBox
            // 
            this.IoTextBox.Location = new System.Drawing.Point(69, 177);
            this.IoTextBox.Name = "IoTextBox";
            this.IoTextBox.Size = new System.Drawing.Size(54, 20);
            this.IoTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Io = ";
            // 
            // XoTextBox
            // 
            this.XoTextBox.Location = new System.Drawing.Point(70, 139);
            this.XoTextBox.Name = "XoTextBox";
            this.XoTextBox.Size = new System.Drawing.Size(54, 20);
            this.XoTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xo =";
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(69, 103);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(54, 20);
            this.NTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "N = ";
            // 
            // ReloadCheckBox
            // 
            this.ReloadCheckBox.AutoSize = true;
            this.ReloadCheckBox.Checked = true;
            this.ReloadCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReloadCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadCheckBox.Location = new System.Drawing.Point(10, 250);
            this.ReloadCheckBox.Name = "ReloadCheckBox";
            this.ReloadCheckBox.Size = new System.Drawing.Size(105, 24);
            this.ReloadCheckBox.TabIndex = 27;
            this.ReloadCheckBox.Text = "Обновлять";
            this.ReloadCheckBox.UseVisualStyleBackColor = true;
            // 
            // SolutionType
            // 
            this.SolutionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SolutionType.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolutionType.FormattingEnabled = true;
            this.SolutionType.Location = new System.Drawing.Point(280, 97);
            this.SolutionType.Name = "SolutionType";
            this.SolutionType.Size = new System.Drawing.Size(231, 26);
            this.SolutionType.TabIndex = 28;
            this.SolutionType.SelectedIndexChanged += new System.EventHandler(this.SolutionType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1324, 683);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl MainGraph;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TextBox XoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EpsilonTextBox;
        private System.Windows.Forms.Label EpsilonLabel;
        private System.Windows.Forms.TextBox XmaxTextBox;
        private System.Windows.Forms.Label XmaxLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox HTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label IncLabel;
        private System.Windows.Forms.Label DecLabel;
        private System.Windows.Forms.Label minSLabel;
        private System.Windows.Forms.Label maxSLabel;
        private System.Windows.Forms.ComboBox SolutionType;
        private System.Windows.Forms.CheckBox ReloadCheckBox;
    }
}


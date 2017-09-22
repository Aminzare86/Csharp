namespace ExamWindowsApp
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblVG = new System.Windows.Forms.Label();
			this.lblG = new System.Windows.Forms.Label();
			this.lblIG = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(807, 85);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Student Information";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 31);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(688, 22);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(721, 31);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Assign";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Location = new System.Drawing.Point(12, 104);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(808, 134);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Grade";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "IG",
            "G",
            "VG"});
			this.comboBox2.Location = new System.Drawing.Point(28, 69);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(151, 24);
			this.comboBox2.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(28, 21);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(769, 24);
			this.comboBox1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(234, 69);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 30);
			this.button2.TabIndex = 0;
			this.button2.Text = "Grade";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblVG);
			this.groupBox3.Controls.Add(this.lblG);
			this.groupBox3.Controls.Add(this.lblIG);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Location = new System.Drawing.Point(12, 244);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(808, 257);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Statistics";
			// 
			// lblVG
			// 
			this.lblVG.AutoSize = true;
			this.lblVG.Location = new System.Drawing.Point(133, 133);
			this.lblVG.Name = "lblVG";
			this.lblVG.Size = new System.Drawing.Size(44, 17);
			this.lblVG.TabIndex = 3;
			this.lblVG.Text = "VG: 0";
			// 
			// lblG
			// 
			this.lblG.AutoSize = true;
			this.lblG.Location = new System.Drawing.Point(133, 88);
			this.lblG.Name = "lblG";
			this.lblG.Size = new System.Drawing.Size(35, 17);
			this.lblG.TabIndex = 2;
			this.lblG.Text = "G: 0";
			this.lblG.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblIG
			// 
			this.lblIG.AutoSize = true;
			this.lblIG.Location = new System.Drawing.Point(133, 37);
			this.lblIG.Name = "lblIG";
			this.lblIG.Size = new System.Drawing.Size(38, 17);
			this.lblIG.TabIndex = 1;
			this.lblIG.Text = "IG: 0";
			this.lblIG.Click += new System.EventHandler(this.lblIG_Click_1);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(558, 133);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(216, 81);
			this.button3.TabIndex = 0;
			this.button3.Text = "Generate Statistics";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 500);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblVG;
		private System.Windows.Forms.Label lblG;
		private System.Windows.Forms.Label lblIG;
		private System.Windows.Forms.Button button3;
	}
}


namespace transformeraTvåFiler
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.listBox3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.listBox2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1152, 326);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// listBox3
			// 
			this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox3.FormattingEnabled = true;
			this.listBox3.ItemHeight = 16;
			this.listBox3.Location = new System.Drawing.Point(771, 3);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(378, 320);
			this.listBox3.TabIndex = 2;
			// 
			// listBox2
			// 
			this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 16;
			this.listBox2.Location = new System.Drawing.Point(387, 3);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(378, 320);
			this.listBox2.TabIndex = 1;
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(3, 3);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(378, 320);
			this.listBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 333);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(205, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "Select Parties";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(300, 333);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(205, 45);
			this.button2.TabIndex = 2;
			this.button2.Text = "Select Courses";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(570, 333);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(205, 45);
			this.button3.TabIndex = 3;
			this.button3.Text = "Save File";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialog2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1152, 418);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}


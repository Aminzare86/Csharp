namespace TwoFileProductApp
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.btnAmountsFile = new System.Windows.Forms.Button();
			this.btnQuantitiesFile = new System.Windows.Forms.Button();
			this.btnSaveFile = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialog2";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.listBox3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.listBox2, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, -2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 298);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(3, 3);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(229, 292);
			this.listBox1.TabIndex = 0;
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.ItemHeight = 16;
			this.listBox3.Location = new System.Drawing.Point(475, 3);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(230, 292);
			this.listBox3.TabIndex = 2;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 16;
			this.listBox2.Location = new System.Drawing.Point(239, 3);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(229, 292);
			this.listBox2.TabIndex = 1;
			// 
			// btnAmountsFile
			// 
			this.btnAmountsFile.Location = new System.Drawing.Point(24, 307);
			this.btnAmountsFile.Name = "btnAmountsFile";
			this.btnAmountsFile.Size = new System.Drawing.Size(114, 38);
			this.btnAmountsFile.TabIndex = 1;
			this.btnAmountsFile.Text = "Open first file";
			this.btnAmountsFile.UseVisualStyleBackColor = true;
			this.btnAmountsFile.Click += new System.EventHandler(this.btnAmountsFile_Click);
			// 
			// btnQuantitiesFile
			// 
			this.btnQuantitiesFile.Location = new System.Drawing.Point(290, 315);
			this.btnQuantitiesFile.Name = "btnQuantitiesFile";
			this.btnQuantitiesFile.Size = new System.Drawing.Size(131, 30);
			this.btnQuantitiesFile.TabIndex = 2;
			this.btnQuantitiesFile.Text = "Open second file";
			this.btnQuantitiesFile.UseVisualStyleBackColor = true;
			this.btnQuantitiesFile.Click += new System.EventHandler(this.btnQuantitiesFile_Click);
			// 
			// btnSaveFile
			// 
			this.btnSaveFile.Location = new System.Drawing.Point(530, 315);
			this.btnSaveFile.Name = "btnSaveFile";
			this.btnSaveFile.Size = new System.Drawing.Size(145, 30);
			this.btnSaveFile.TabIndex = 3;
			this.btnSaveFile.Text = "Save third file";
			this.btnSaveFile.UseVisualStyleBackColor = true;
			this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 365);
			this.Controls.Add(this.btnSaveFile);
			this.Controls.Add(this.btnQuantitiesFile);
			this.Controls.Add(this.btnAmountsFile);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button btnAmountsFile;
		private System.Windows.Forms.Button btnQuantitiesFile;
		private System.Windows.Forms.Button btnSaveFile;
	}
}


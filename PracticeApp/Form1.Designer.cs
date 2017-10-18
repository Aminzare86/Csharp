namespace PracticeApp
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
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.SaveBt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pershonNrTimePicker = new System.Windows.Forms.DateTimePicker();
			this.canvertBt = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(49, 48);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(246, 22);
			this.NameTextBox.TabIndex = 0;
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(49, 172);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(246, 22);
			this.PhoneTextBox.TabIndex = 2;
			// 
			// SaveBt
			// 
			this.SaveBt.Location = new System.Drawing.Point(49, 222);
			this.SaveBt.Name = "SaveBt";
			this.SaveBt.Size = new System.Drawing.Size(75, 23);
			this.SaveBt.TabIndex = 3;
			this.SaveBt.Text = "Save";
			this.SaveBt.UseVisualStyleBackColor = true;
			this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "PersonNr:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Phone:";
			// 
			// pershonNrTimePicker
			// 
			this.pershonNrTimePicker.Location = new System.Drawing.Point(55, 108);
			this.pershonNrTimePicker.Name = "pershonNrTimePicker";
			this.pershonNrTimePicker.Size = new System.Drawing.Size(200, 22);
			this.pershonNrTimePicker.TabIndex = 7;
			// 
			// canvertBt
			// 
			this.canvertBt.Location = new System.Drawing.Point(197, 222);
			this.canvertBt.Name = "canvertBt";
			this.canvertBt.Size = new System.Drawing.Size(75, 23);
			this.canvertBt.TabIndex = 8;
			this.canvertBt.Text = "Canvert";
			this.canvertBt.UseVisualStyleBackColor = true;
			this.canvertBt.Click += new System.EventHandler(this.canvertBt_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 355);
			this.Controls.Add(this.canvertBt);
			this.Controls.Add(this.pershonNrTimePicker);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SaveBt);
			this.Controls.Add(this.PhoneTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox PhoneTextBox;
		private System.Windows.Forms.Button SaveBt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DateTimePicker pershonNrTimePicker;
		private System.Windows.Forms.Button canvertBt;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}


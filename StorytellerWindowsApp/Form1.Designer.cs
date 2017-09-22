namespace StorytellerWindowsApp
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbNameOfChild = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbStory = new System.Windows.Forms.TextBox();
			this.btnTellStory = new System.Windows.Forms.Button();
			this.cbScary = new System.Windows.Forms.CheckBox();
			this.numAge = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name of Child";
			// 
			// tbNameOfChild
			// 
			this.tbNameOfChild.Location = new System.Drawing.Point(16, 34);
			this.tbNameOfChild.Name = "tbNameOfChild";
			this.tbNameOfChild.Size = new System.Drawing.Size(317, 22);
			this.tbNameOfChild.TabIndex = 1;
			this.tbNameOfChild.Click += new System.EventHandler(this.btnTellStory_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Age of Child";
			// 
			// tbStory
			// 
			this.tbStory.Location = new System.Drawing.Point(9, 239);
			this.tbStory.Multiline = true;
			this.tbStory.Name = "tbStory";
			this.tbStory.Size = new System.Drawing.Size(610, 112);
			this.tbStory.TabIndex = 3;
			// 
			// btnTellStory
			// 
			this.btnTellStory.Location = new System.Drawing.Point(16, 198);
			this.btnTellStory.Name = "btnTellStory";
			this.btnTellStory.Size = new System.Drawing.Size(116, 35);
			this.btnTellStory.TabIndex = 4;
			this.btnTellStory.Text = "Tell story!";
			this.btnTellStory.UseVisualStyleBackColor = true;
			this.btnTellStory.Click += new System.EventHandler(this.btnTellStory_Click);
			// 
			// cbScary
			// 
			this.cbScary.AutoSize = true;
			this.cbScary.Location = new System.Drawing.Point(12, 159);
			this.cbScary.Name = "cbScary";
			this.cbScary.Size = new System.Drawing.Size(132, 21);
			this.cbScary.TabIndex = 5;
			this.cbScary.Text = "Should be scary";
			this.cbScary.UseVisualStyleBackColor = true;
			// 
			// numAge
			// 
			this.numAge.Location = new System.Drawing.Point(12, 117);
			this.numAge.Name = "numAge";
			this.numAge.Size = new System.Drawing.Size(120, 22);
			this.numAge.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 363);
			this.Controls.Add(this.numAge);
			this.Controls.Add(this.cbScary);
			this.Controls.Add(this.btnTellStory);
			this.Controls.Add(this.tbStory);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNameOfChild);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNameOfChild;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbStory;
		private System.Windows.Forms.Button btnTellStory;
		private System.Windows.Forms.CheckBox cbScary;
		private System.Windows.Forms.NumericUpDown numAge;
	}
}


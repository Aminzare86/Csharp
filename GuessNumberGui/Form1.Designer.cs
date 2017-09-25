namespace GuessNumberGui
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
			this.txtGuess = new System.Windows.Forms.TextBox();
			this.btnGuess = new System.Windows.Forms.Button();
			this.lblFeedback = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtGuess
			// 
			this.txtGuess.Location = new System.Drawing.Point(5, 38);
			this.txtGuess.Name = "txtGuess";
			this.txtGuess.Size = new System.Drawing.Size(692, 22);
			this.txtGuess.TabIndex = 0;
			// 
			// btnGuess
			// 
			this.btnGuess.Location = new System.Drawing.Point(131, 127);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(438, 59);
			this.btnGuess.TabIndex = 1;
			this.btnGuess.Text = "Guess";
			this.btnGuess.UseVisualStyleBackColor = true;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// lblFeedback
			// 
			this.lblFeedback.AutoSize = true;
			this.lblFeedback.Location = new System.Drawing.Point(59, 276);
			this.lblFeedback.Name = "lblFeedback";
			this.lblFeedback.Size = new System.Drawing.Size(0, 17);
			this.lblFeedback.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(709, 306);
			this.Controls.Add(this.lblFeedback);
			this.Controls.Add(this.btnGuess);
			this.Controls.Add(this.txtGuess);
			this.Name = "Form1";
			this.Text = "Guess a Namber";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtGuess;
		private System.Windows.Forms.Button btnGuess;
		private System.Windows.Forms.Label lblFeedback;
	}
}


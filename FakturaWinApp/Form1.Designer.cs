namespace FakturaWinApp
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
			this.gbKund = new System.Windows.Forms.GroupBox();
			this.btnSkapaPart = new System.Windows.Forms.Button();
			this.txtJuridisktId = new System.Windows.Forms.TextBox();
			this.txtNamn = new System.Windows.Forms.TextBox();
			this.gbValjProdukt = new System.Windows.Forms.GroupBox();
			this.lbRader = new System.Windows.Forms.ListBox();
			this.cbAntal = new System.Windows.Forms.ComboBox();
			this.cbValjProdukt = new System.Windows.Forms.ComboBox();
			this.btnNyRad = new System.Windows.Forms.Button();
			this.btnLäggBeställning = new System.Windows.Forms.Button();
			this.gbKund.SuspendLayout();
			this.gbValjProdukt.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbKund
			// 
			this.gbKund.Controls.Add(this.btnSkapaPart);
			this.gbKund.Controls.Add(this.txtJuridisktId);
			this.gbKund.Controls.Add(this.txtNamn);
			this.gbKund.Location = new System.Drawing.Point(13, 13);
			this.gbKund.Name = "gbKund";
			this.gbKund.Size = new System.Drawing.Size(640, 148);
			this.gbKund.TabIndex = 0;
			this.gbKund.TabStop = false;
			this.gbKund.Text = "Kund";
			// 
			// btnSkapaPart
			// 
			this.btnSkapaPart.Location = new System.Drawing.Point(26, 105);
			this.btnSkapaPart.Name = "btnSkapaPart";
			this.btnSkapaPart.Size = new System.Drawing.Size(591, 37);
			this.btnSkapaPart.TabIndex = 2;
			this.btnSkapaPart.Text = "Skapa Part";
			this.btnSkapaPart.UseVisualStyleBackColor = true;
			this.btnSkapaPart.Click += new System.EventHandler(this.btnSkapaPart_Click);
			// 
			// txtJuridisktId
			// 
			this.txtJuridisktId.Location = new System.Drawing.Point(24, 63);
			this.txtJuridisktId.Name = "txtJuridisktId";
			this.txtJuridisktId.Size = new System.Drawing.Size(593, 22);
			this.txtJuridisktId.TabIndex = 1;
			// 
			// txtNamn
			// 
			this.txtNamn.Location = new System.Drawing.Point(26, 22);
			this.txtNamn.Name = "txtNamn";
			this.txtNamn.Size = new System.Drawing.Size(593, 22);
			this.txtNamn.TabIndex = 0;
			// 
			// gbValjProdukt
			// 
			this.gbValjProdukt.Controls.Add(this.lbRader);
			this.gbValjProdukt.Controls.Add(this.cbAntal);
			this.gbValjProdukt.Controls.Add(this.cbValjProdukt);
			this.gbValjProdukt.Controls.Add(this.btnNyRad);
			this.gbValjProdukt.Location = new System.Drawing.Point(17, 167);
			this.gbValjProdukt.Name = "gbValjProdukt";
			this.gbValjProdukt.Size = new System.Drawing.Size(640, 163);
			this.gbValjProdukt.TabIndex = 1;
			this.gbValjProdukt.TabStop = false;
			this.gbValjProdukt.Text = "välj produkt";
			// 
			// lbRader
			// 
			this.lbRader.FormattingEnabled = true;
			this.lbRader.ItemHeight = 16;
			this.lbRader.Location = new System.Drawing.Point(201, 22);
			this.lbRader.Name = "lbRader";
			this.lbRader.Size = new System.Drawing.Size(415, 116);
			this.lbRader.TabIndex = 6;
			// 
			// cbAntal
			// 
			this.cbAntal.FormattingEnabled = true;
			this.cbAntal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cbAntal.Location = new System.Drawing.Point(25, 73);
			this.cbAntal.Name = "cbAntal";
			this.cbAntal.Size = new System.Drawing.Size(121, 24);
			this.cbAntal.TabIndex = 5;
			// 
			// cbValjProdukt
			// 
			this.cbValjProdukt.FormattingEnabled = true;
			this.cbValjProdukt.Location = new System.Drawing.Point(25, 22);
			this.cbValjProdukt.Name = "cbValjProdukt";
			this.cbValjProdukt.Size = new System.Drawing.Size(121, 24);
			this.cbValjProdukt.TabIndex = 4;
			// 
			// btnNyRad
			// 
			this.btnNyRad.Location = new System.Drawing.Point(25, 129);
			this.btnNyRad.Name = "btnNyRad";
			this.btnNyRad.Size = new System.Drawing.Size(114, 28);
			this.btnNyRad.TabIndex = 3;
			this.btnNyRad.Text = "Ny Rad";
			this.btnNyRad.UseVisualStyleBackColor = true;
			this.btnNyRad.Click += new System.EventHandler(this.btnNyRad_Click);
			// 
			// btnLäggBeställning
			// 
			this.btnLäggBeställning.Location = new System.Drawing.Point(42, 349);
			this.btnLäggBeställning.Name = "btnLäggBeställning";
			this.btnLäggBeställning.Size = new System.Drawing.Size(591, 37);
			this.btnLäggBeställning.TabIndex = 3;
			this.btnLäggBeställning.Text = "Lägg beställning";
			this.btnLäggBeställning.UseVisualStyleBackColor = true;
			this.btnLäggBeställning.Click += new System.EventHandler(this.btnLäggBeställning_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 389);
			this.Controls.Add(this.btnLäggBeställning);
			this.Controls.Add(this.gbValjProdukt);
			this.Controls.Add(this.gbKund);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbKund.ResumeLayout(false);
			this.gbKund.PerformLayout();
			this.gbValjProdukt.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbKund;
		private System.Windows.Forms.TextBox txtJuridisktId;
		private System.Windows.Forms.TextBox txtNamn;
		private System.Windows.Forms.GroupBox gbValjProdukt;
		private System.Windows.Forms.Button btnSkapaPart;
		private System.Windows.Forms.Button btnNyRad;
		private System.Windows.Forms.Button btnLäggBeställning;
		private System.Windows.Forms.ComboBox cbAntal;
		private System.Windows.Forms.ComboBox cbValjProdukt;
		private System.Windows.Forms.ListBox lbRader;
	}
}


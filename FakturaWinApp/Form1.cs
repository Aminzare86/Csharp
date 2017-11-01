using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakturaLibb;

namespace FakturaWinApp
{
	public partial class Form1 : Form
	{
		private FakturaSystem fakturaSystem = new FakturaSystem();
		private Part part;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSkapaPart_Click(object sender, EventArgs e)
		{
			part = fakturaSystem.SkapaPart(txtNamn.Text, txtJuridisktId.Text);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbValjProdukt.Items.Add(fakturaSystem.SkapaProdukt("Teddy", 79M));
			cbValjProdukt.Items.Add(fakturaSystem.SkapaProdukt("Ponny", 15000M));
		}

		private void btnNyRad_Click(object sender, EventArgs e)
		{
			lbRader.Items.Add(
			   new Rad
			   {
				   Produkt = (Produkt)cbValjProdukt.SelectedItem,
				   Antal = int.Parse(cbAntal.SelectedItem.ToString())
			   }
		   );
		}

		private void btnLäggBeställning_Click(object sender, EventArgs e)
		{
			var beställning = fakturaSystem.SkapaBeställning(part);
			foreach (Rad rad in lbRader.Items)
			{
				beställning.NyRad(rad.Produkt, rad.Antal);
			}
			var faktura = beställning.GenereraFaktura();
			MessageBox.Show(faktura.ToString());
		}
	}
}

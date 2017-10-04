using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string Name = NameBox.Text;
			string personNr = PersonNrBox.Text;
			var personNrSub = personNr.Substring(9, 1);
			int personNrToInt = Convert.ToInt32(personNrSub) % 2;
			if (personNrToInt == 1)
			{
				ShowLbl.Text=$"God morgon herr {Name}";
			}
			else
			{
				ShowLbl.Text=$"God morgon fröken { Name}";
			};
		}



	}
}

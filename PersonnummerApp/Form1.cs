using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonnummerLib2;
namespace PersonnummerApp
{
	public partial class Form1 : Form
	{
		PersonnummerDigitFinderSimple simple =
			new PersonnummerDigitFinderSimple();
		public Form1()
		{
			InitializeComponent();
		}
		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{
			if (textBox1.Text.Length == 9)
			{
				simple.Process(textBox1.Text);
				label1.Text = simple.LastDigit;
			}
		}
	}

}

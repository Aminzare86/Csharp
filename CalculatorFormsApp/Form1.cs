using CalculatorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFormsApp
{
	public partial class Form1 : Form
	{
		private Calculator Calculator = new Calculator();
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var aButton = (Button)sender;
			Calculator.Press(aButton.Text);
			label1.Text = Calculator.Display.ToString();
		}
	}
}

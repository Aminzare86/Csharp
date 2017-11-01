using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog2.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
				var streamReader = File.OpenText(openFileDialog1.FileName);
				var streamReader2 = File.OpenText(openFileDialog2.FileName);
			

			while (true)
				{
				var Line = streamReader.ReadLine();
				if (Line == null )
				break;
				var amount = decimal.Parse(Line, CultureInfo.InvariantCulture);
				//var Line2 = streamReader2.ReadLine();

				//while (true)
				//{
				for (int i = 0; i < 2; i++)
				{
					var Line2 = streamReader2.ReadLine();
					var amount2 = decimal.Parse(Line2, CultureInfo.InvariantCulture);
					var totalGånger = amount * amount2;
					var totalToString = Convert.ToString(totalGånger);
					File.AppendAllText(saveFileDialog1.FileName, totalToString);
				}
					//var Line2 = streamReader2.ReadLine();
					//if (Line2 == null && Line==null)
					//	break;
					//var amount2 = decimal.Parse(Line2, CultureInfo.InvariantCulture);
					//var totalGånger = amount * amount2;
					//var totalToString = Convert.ToString(totalGånger);
					//File.AppendAllText(saveFileDialog1.FileName, totalToString);
				//}
			}
			//while (true)
			//{
			//	 Line2 = streamReader.ReadLine();
			//	if (Line2 == null)
			//		break;
			//	var amount = decimal.Parse(Line, CultureInfo.InvariantCulture);
			//	var amount2 = decimal.Parse(Line2, CultureInfo.InvariantCulture);
			//	var totalGånger = amount * amount2;
			//	var totalToString = Convert.ToString(totalGånger);
			//	File.AppendAllText(saveFileDialog1.FileName, totalToString);

			//}

			//foreach (var entry in accounts.OrderBy(e => e.Key))
			//	Debug.WriteLine($"{entry.Key}{entry.Value.ToString("F2") }");
			{
				}
				//Debug.WriteLine(accounts.Sum(entry => entry.Value));		
		}
	}
}

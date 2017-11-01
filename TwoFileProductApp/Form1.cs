using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoFilesProductLib;

namespace TwoFileProductApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAmountsFile_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			var lines = File.ReadAllLines(openFileDialog1.FileName);
			foreach (var line in lines)
			{
				listBox1.Items.Add(line);
			}
		}

		private void btnQuantitiesFile_Click(object sender, EventArgs e)
		{
			openFileDialog2.ShowDialog();
			var lines = File.ReadAllLines(openFileDialog2.FileName);
			foreach (var line in lines)
			{
				listBox2.Items.Add(line);
			}
			var content1 = File.ReadAllText(openFileDialog1.FileName);
			var content2 = File.ReadAllText(openFileDialog2.FileName);
			var result = TwoFilesProduct.Transform(content1, content2);
			var stringReader = new StringReader(result);
			while (true)
			{
				var line = stringReader.ReadLine();
				if (line == null)
					break;
				listBox3.Items.Add(line);
			}
		}
		private void btnSaveFile_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			var content1 = File.ReadAllText(openFileDialog1.FileName);
			var content2 = File.ReadAllText(openFileDialog2.FileName);
			var result = TwoFilesProduct.Transform(content1, content2);
			File.WriteAllText(saveFileDialog1.FileName, result);

		}
	}
}

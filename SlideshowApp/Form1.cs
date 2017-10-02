using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideshowApp
{
	public partial class Form1 : Form
	{
		private int filenumber = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Laod(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			DisplayFileNumber(filenumber);
			filenumber++;
			if(filenumber >= openFileDialog1.FileNames.Count())
			{
				filenumber = 0;
			}
		}

		private void DisplayFileNumber(int fileNumber)
		{
			pictureBox1.ImageLocation = openFileDialog1.FileNames[fileNumber];
			pictureBox1.Load();
		}
	}
}

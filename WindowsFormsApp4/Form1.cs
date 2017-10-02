using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
	public partial class Form1 : Form
	{
		private int fileNumber;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			pictureBox1.ImageLocation = openFileDialog1.FileNames[0];
			pictureBox1.Load();

		}
		private void timer1_Tick(object sender, EventArgs e)
		{

		}
	}
}

using PracticLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SaveBt_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			string name = NameTextBox.Text;
			string Phone = PhoneTextBox.Text;
			var personNr = pershonNrTimePicker.Value.ToString("yyyy-MM-dd");
			string PershoInfo = PersonalInfo.Transform(name, Phone, personNr);
			File.AppendAllText(saveFileDialog1.FileName, PershoInfo);
		}

		private void canvertBt_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			saveFileDialog1.ShowDialog();
			string content = File.ReadAllText(openFileDialog1.FileName);
			string test = PersonalInfo.Convert(content);
			File.AppendAllText(saveFileDialog1.FileName, test);
		}

	}
}

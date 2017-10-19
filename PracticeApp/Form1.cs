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
			savePersonInfo(name, Phone, personNr);
		}
		private void savePersonInfo(string name, string Phone, string personNr)
		{
			string pattern = @"(\d{3})(\d{7})";
			Match m = Regex.Match(Phone, pattern);
			string Phonepart1 = m.Groups[1].Value;
			string Phonepart2 = m.Groups[2].Value;
			string editPhone = Phonepart1 + "-" + Phonepart2;
			string PershoInfo = personNr + ";" + name + ";" + editPhone + ";";
			File.AppendAllText(saveFileDialog1.FileName, PershoInfo);
		}

		private void canvertBt_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			string pattern2 = @"(\d{4})-(\w+-\w+);(\w+ \w+);(\w+-\w+);";
			saveFileDialog1.ShowDialog();
			string content = File.ReadAllText(openFileDialog1.FileName);
			ConvertPersonInfo(pattern2, content);
		}
		private void ConvertPersonInfo(string pattern2, string content)
		{
			Match m = Regex.Match(content, pattern2);
			string convertPart1 = m.Groups[1].Value;
			string convertPart3 = m.Groups[3].Value;
			string convertPart4 = m.Groups[4].Value;
			var age = int.Parse(m.Groups[1].Value);
			var year = DateTime.Now.AddYears(-age).Year;
			string test = $"{convertPart3} är {year} år gammal och har telefonumret {convertPart4}";
			File.AppendAllText(saveFileDialog1.FileName, test);
		}
	}
}

using System;
using System.Collections;
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
namespace transformeraTvåFiler
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
			var lines = File.ReadAllLines(openFileDialog1.FileName);
			foreach (var line in lines)
			{
				listBox1.Items.Add(line);
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog2.ShowDialog();
			var lines = File.ReadAllLines(openFileDialog2.FileName);
			foreach (var line in lines)
			{
				listBox2.Items.Add(line);
			}
			var content1 = File.OpenText(openFileDialog1.FileName);
			var content2 = File.OpenText(openFileDialog2.FileName);
			ListBoxFileProduct( ref content1, content2);
		}
		private void ListBoxFileProduct( ref StreamReader content1, StreamReader content2)
		{
			var kurs = "";
			ArrayList studentsList = new ArrayList();
			var numerrofWord = 0;
			var studentname = "";
			var filesWord = "";
			while (true)
			{
				string pattern2 = @"([^""]*);(\d{4}-\d{2}-\d{2});(\d{4}-\d{2}-\d{2})";
				var Line2 = content2.ReadLine();
				if (Line2 == null )
					break;
				Match match2 = Regex.Match(Line2, pattern2);
				kurs = match2.Groups[1].Value;
				var date1 = match2.Groups[2].Value;
				DateTime dt = Convert.ToDateTime(date1);
				var date2 = match2.Groups[3].Value;
				DateTime dt2 = Convert.ToDateTime(date2);
				var numberOfDays = (dt2 - dt).TotalDays;
				string pattern = @"(\w*)";
				RegexOptions options = RegexOptions.Multiline;
				while (true)
				{
					var Line = content1.ReadLine();
					if (Line == null)
					{
						content1 = File.OpenText(openFileDialog1.FileName);
						break;
					}
					foreach (Match m in Regex.Matches(Line, pattern, options))
					{
						if (kurs == filesWord)
						{
							studentsList.Add(studentname);
						}
						filesWord = m.Value;
						if (filesWord == "C")
						{
							filesWord += "#";
						}
						numerrofWord = m.Index;
						if (numerrofWord == 0)
						{
							studentname = filesWord;
						}
					}
				}
				numerrofWord = 0;
				var kursStudent = "";
				foreach (object item in studentsList)
				{
					kursStudent += item.ToString() + ";";
				}
				listBox3.Items.Add($"Kursen {kurs} pågår i " +
				$"{numberOfDays} dagar med följande deltagare:{kursStudent}");
				studentsList.Clear();
			}
		}
		private void SaveFileProduct(ref string output, ref StreamReader content1, StreamReader content2)
		{
			var kurs = "";
			ArrayList studentsList = new ArrayList();
			var numerrofWord = 0;
			var studentname = "";
			var filesWord = "";
			while (true)
			{
				string pattern2 = @"([^""]*);(\d{4}-\d{2}-\d{2});(\d{4}-\d{2}-\d{2})";
				var Line2 = content2.ReadLine();
				if (Line2 == null /*|| Line==null*/)
					break;
				Match match2 = Regex.Match(Line2, pattern2);
				kurs = match2.Groups[1].Value;
				var date1 = match2.Groups[2].Value;
				DateTime dt = Convert.ToDateTime(date1);
				var date2 = match2.Groups[3].Value;
				DateTime dt2 = Convert.ToDateTime(date2);
				var numberOfDays = (dt2 - dt).TotalDays;
				string pattern = @"(\w*)";
				RegexOptions options = RegexOptions.Multiline;
				while (true)
				{
					var Line = content1.ReadLine();
					if (Line == null)
					{
						content1 = File.OpenText(openFileDialog1.FileName);
						break;
					}
					foreach (Match m in Regex.Matches(Line, pattern, options))
					{
						if (kurs == filesWord)
						{
							studentsList.Add(studentname);
						}
						filesWord = m.Value;
						if (filesWord == "C")
						{
							filesWord += "#";
						}
						numerrofWord = m.Index;
						if (numerrofWord == 0)
						{
							studentname = filesWord;
						}
					}
				}
				numerrofWord = 0;
				var kursStudent = "";
				foreach (object item in studentsList)
				{
					kursStudent += item.ToString() + ";";
				}
				output += $"Kursen {kurs} pågår i " + $"{numberOfDays} dagar med följande deltagare:{kursStudent}{Environment.NewLine}";

				studentsList.Clear();

			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			string output = "";	
			var content1 = File.OpenText(openFileDialog1.FileName);
			var content2 = File.OpenText(openFileDialog2.FileName);
			SaveFileProduct(ref output, ref content1, content2);
			File.WriteAllText(saveFileDialog1.FileName, output);
		}
	}
}

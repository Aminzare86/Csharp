using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
	public class Student
	{
		private string name;
		private string email;
		private string Adress;
		private string Bil;
		public int countStudy=0;
		public Student()
		{
		}
		public Student(string Adress, string Bil)
		{
			this.Adress = Adress;
			this.Bil = Bil;
		}
		public string Name
		{
			get
			{ return name; }
			set { name = value; }
		}
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		public void StudentInfo()
		{
			Console.WriteLine(name + "\n" + email);
			Console.WriteLine(Adress + "\n" + Bil);

		}
		public void StudyHarder()
		{
			countStudy++;
			if (countStudy < 3)
			{
				Console.WriteLine("you have to study harder");
			}
			else
			{
				Console.WriteLine("Amin need to rest");

			}
		}
	}
}

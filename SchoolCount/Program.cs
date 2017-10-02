using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCount
{
	class Program
	{
		static void Main(string[] args)
		{
			School school = new School();
			Class class1 = new Class(34);
			Class class2 = new Class(23);
			Class class3 = new Class(43);
			school.Classes.Add(class1);
			school.Classes.Add(class1);
			school.Classes.Add(class1);
			Console.WriteLine($"There are {school.NumberOfStudents} number of students in this school.");
			Console.ReadLine();

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;
namespace Student
{
	class Program
	{
		static void Main(string[] args)
		{
			Student Amin = new Student();
			Student AminInfo = new Student(Adress: "Fyrspanssgata172", Bil: "audi");
			Student Aminsstudy = new Student();
			Student Aminsrest = new Student();
			Amin.Name = "Mohammad amin zare";
			Amin.Email = "zare.mohammadamin@gmail.com";
			Amin.StudentInfo();
			AminInfo.StudentInfo();
			Aminsstudy.StudyHarder();
			Aminsstudy.StudyHarder();
			Aminsstudy.StudyHarder();
			Console.ReadKey();
		}

	}
}

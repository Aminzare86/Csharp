using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolLib
{
	public class SchoolSystem
	{
		private List<Class> classes = new List<Class>();
		public int ClassCount
		{
			get
			{
				return classes.Count;
			}
		}
		public int StudentCount
		{
			get
			{
				return classes.Sum(c =>c.NumberOfStudent);
			}
		}
		public void AddClass(string className, int numberOfStudent)
		{
			var Class = classes.SingleOrDefault(c => c.Name == className);
			if (Class!=null)
			{
				Class.NumberOfStudent += numberOfStudent;
			}
			else
			{
				classes.Add(new Class {Name=className,NumberOfStudent=numberOfStudent });
			}
		}
	}
}

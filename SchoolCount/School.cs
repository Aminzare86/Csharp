using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCount
{
	class School
	{
		public List<Class> Classes { get; internal set; } = new List<Class>();
		public int NumberOfStudents
		{
			get
			{
				return this.Classes.Sum(Class => Class.students);
				
			}
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			StudentDemo();
			InheritanceDemo();
			Console.ReadLine();
		}

		private static void InheritanceDemo() {
		
			Animal anAnimal = new Animal();
			anAnimal.Eat();
			Lion aLion = new Lion();
			aLion.Eat();
				
		}
	
			private static void StudentDemo()
	    	{
			var Amin = new Student();
			
			Amin.Name = "Mohammad amin zare";
			Amin.Email = "zare.mohammadamin@gmail.com";
			Amin.TooTired += Amin_TooTired;
			Amin.StudyHarder();
			Amin.StudyHarder();
			Amin.StudyHarder();
			//Console.WriteLine("Hello word {0}.",Name);

			Console.WriteLine($"Hello word {Amin}");
			Console.ReadLine();
		    }

		private static void Amin_TooTired(object sender, EventArgs e)
		{
			int x = 5;
			Console.WriteLine("Student need to rest{0}.",x);
			Console.ReadLine();

		}
	}
}

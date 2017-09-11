using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
	public class FileConverter
	{
		public string Transform(string row)
		{
			string[] toknes = row.Split(';');
			var firstName = toknes[0].ToUpper();
			var lastName = toknes[1].ToUpper();
			var years = DateTime.Now.Year - int.Parse(toknes[2]);
			var message = $"{firstName} {lastName} ÄR { years} ÅR GAMMAL.";
			return message;
		}
		public string Transform1(string row)
		{
			string[] toknes = row.Split(';');
			var firstName = toknes[0].ToUpper();
			var lastName = toknes[1].ToUpper();
			var years = DateTime.Now.Year - int.Parse(toknes[2]);
			var message = $"{firstName} {lastName} ÄR { years} ÅR GAMMAL.";
			return message;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
	public class ListHandler
	{
		public List<string> List = new List<string>();

		public void AddFiveStrings()
		{
			List.Add("Sharepoint är roligt");
			List.Add("Jag är Sharepoint developer");
			List.Add("jag kan javaScript");
			List.Add("Jag kan HTML");
			List.Add("Jag kan Css");
		}

		public void RemoveThirdString()
		{
			List.Remove("jag kan javaScript");
		}

		public void Sort()
		{
			List.Sort();
		}
	}
}

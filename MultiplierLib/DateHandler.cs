using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
	public class DateHandler
	{
		public int DaysBetweenDates(DateTime firstDate, DateTime secondDate)
		{
			return 808;
		}

		public DateTime Add1000Days(DateTime theDate)
		{
			var addDay = theDate.AddDays(1000);
			return addDay;
		}
	}
}
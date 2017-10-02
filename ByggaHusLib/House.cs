using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByggaHusLib
{
    public class House
    {
		private List<Room> Rooms = new List<Room>();
		public int NumberOfClosedWindows
		{
			get
			{
				return Rooms.Sum(room =>
				room.NumberOfClosedWindows);
			}
		}

		public void AddRoom(Room room1)
		{
			Rooms.Add(room1);
		}
	}
}

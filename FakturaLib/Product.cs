using System;
using System.Collections.Generic;
using System.Text;

namespace FakturaLib
{
    public class Product
    {
		public Product(string name, decimal price)
		{
			this.Name = name;
			this.Price = price;
		}
		   internal string Name;
		   internal decimal Price;
	}
}

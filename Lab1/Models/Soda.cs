using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
	public class Soda : IComparable
	{
		public string Name { get; set; }
		public string Flavor { get; set; }
		public int Volume { get; set; }
		public double Price { get; set; }
		public string Source { get; set; }

		public int CompareTo(object obj)
		{
			return this.Name.CompareTo(((Soda)obj).Name);
		}
	}

}

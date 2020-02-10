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

		public static Comparison<Soda> ByName = delegate (Soda so1, Soda so2)
		{
			return so1.Name.CompareTo(so2.Name);
		};
		public int CompareTo(object obj)
		{
			var vCompare = (Soda)obj;
			return this.Name.CompareTo(((Soda)obj).Name);
		}
	}

}

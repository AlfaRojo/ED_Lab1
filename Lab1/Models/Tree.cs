using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
	public class Tree<T> where T : IComparable
	{
		private Node<T> Root;

		private Comparison<IComparable> Comparer = ComparerElements;

		public void Insert(Soda myNode)
		{

		}
		public T Find(string ID)
		{

		}
		private static int ComparerElements(IComparable value, IComparable sInformacion)
		{
			return value.CompareTo(sInformacion);
		}
	}
}
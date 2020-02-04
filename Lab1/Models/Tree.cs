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
		public T[] Find(Delegate comparer, T[] Value)
		{
			for (int i = 0; i < Value.Length; i++)
			{
				for (int j = 0; j < Value.Length; j++)
				{
					if ((int)Comparer.DynamicInvoke(Value[i], Value[j])== 0)
					{
						var Aux = Value[i];
						Value[i] = Value[j];
						Value[j] = Aux;
					}
				}
			}
			return Value;

		}
		private static int ComparerElements(IComparable value, IComparable sInformacion)
		{
			return value.CompareTo(sInformacion);
		}
	}
}
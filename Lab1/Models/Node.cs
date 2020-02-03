using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
	public class Node <T>
	{
		int id;
		int father;
		bool isLeaf = true;
		Node<T>[] children;
		T[] value;
	}
}

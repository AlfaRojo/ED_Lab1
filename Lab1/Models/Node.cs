using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Lab1.Models
{
	public class Node <T>
	{
        public Soda myInformation { get; set; }
        public Node<T> nRight { get; set; }
        public Node<T> nLeft { get; set; }
        public Node<T> father { get; set; }
        public bool root { get { return father == null; } }
        public bool leaf { get { return nLeft == null && nRight == null; } }

        public Node(Soda value, Node<T> father, Node<T> Left, Node<T> right)
        {
            myInformation = value;
            this.nRight = right;
            this.nLeft = Left;
            this.father = father;
        }
        public Node(Soda Value)
        {
            myInformation = Value;
        }
        public Node(Soda Value, Node<T> Father)
        {
            myInformation = Value;
            this.father = Father;
        }

    }
}

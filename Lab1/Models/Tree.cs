using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Tree<TK, TP> where TK : IComparable<TK>
    {
        private Comparison<IComparable> Comparer = ComparerElements;
        public Node<TK, TP> root { get; private set; }
        public int Grade { get; private set; }
        public int High { get; private set; }

        public void Insert(Soda myNode)
        {

        }
        public Index<TK, TP> AllSerch(TK ID)
        {
            return this.Search(this.root, ID);
        }
        private Index<TK, TP> Search(Node<TK, TP> tempNode, TK ID)
        {
            int i = tempNode.myInformation.TakeWhile(Index => ID.CompareTo(Index.ID) > 0).Count();
            if (i < tempNode.myInformation.Count && tempNode.myInformation[i].ID.CompareTo(ID)==0)
            {
                return tempNode.myInformation[i];
            }
            return tempNode.isleaf ? null : this.Search(tempNode.myNode[i], ID);
        }
        private static int ComparerElements(IComparable value, IComparable sInformacion)
        {
            return value.CompareTo(sInformacion);
        }
    }
}
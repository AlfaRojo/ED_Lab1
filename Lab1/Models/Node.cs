using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Web;

namespace Lab1.Models
{
    public class Node<TKey, T>
    {
        public List<Soda> myInformation { get; set; }
        public List<int> children { get; set; }
        public List<TKey> key { get; set; }
        public int father { get; set; }
        public int order { get; set; }
        public int position { get; set; }

        public Node(List<Soda> Data, List<int> myChildren, List<TKey> myKey, int myFather, int myOrder, int myPositioin)
        {
            this.myInformation = Data;
            this.children = myChildren;
            this.key = myKey;
            this.father = myFather;
            this.position = myPositioin;
            this.order = myOrder;
        }
        public Node()
        {
            myInformation = new List<Soda>();
            children = new List<int>();
            key = new List<TKey>();
        }
    }
}

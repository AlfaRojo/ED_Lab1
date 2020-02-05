using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Web;

namespace Lab1.Models
{
    public class Node<TK, TP>
    {
        public List<Index<TK, TP>> myInformation { get; set; }
        public List<Node<TK, TP>> myNode { get; set; }
        private int grade;

        public Node(int myGrade)
        {
            this.grade = myGrade;
            myNode = new List<Node<TK, TP>>();
            myInformation = new List<Index<TK, TP>>();

        }
        public bool isleaf
        {
            get { return this.myNode.Count == 0; }
        }
        public bool MaxValues
        {
            get { return this.myInformation.Count == (2 * this.grade) - 1; }
        }
        public bool MinValues
        {
            get { return this.myInformation.Count == this.grade - 1; }
        }
    }
}

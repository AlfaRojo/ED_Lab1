using System;
using System.Linq;

namespace Lab1.Models
{
    public class Tree<TK, TP> where TK : IComparable<TK>
    {
        //private Comparison<IComparable> Comparer = ComparerElements;
        public Node<TK, TP> root { get; private set; }
        public int Grade { get; private set; }
        public int High { get; private set; }
        public Tree(int myGrade)
        {
            if (myGrade < 2)
            {
                throw new ArgumentException("Grado de arbol debe de ser mayor a 2");
            }
            this.root = new Node<TK, TP>(myGrade);
            this.Grade = myGrade;
            this.High = 1;
        }
        public void Insert(TK myID, TP myPointer)
        {
            if (!this.root.MaxValues)
            {
                this.InsertTo(this.root, myID, myPointer);
                return;
            }
            Node<TK, TP> oldRoot = this.root;
            this.root = new Node<TK, TP>(this.Grade);
            this.DivideSon(this.root, 0, oldRoot);
            this.InsertTo(this.root,myID, myPointer);
            this.High++;
        }
        private void InsertTo(Node<TK, TP> tempNode, TK newID, TP newPointer)
        {
            int positionInsert = tempNode.myInformation.TakeWhile(entry => newID.CompareTo(entry.ID) >= 0).Count();
            if (tempNode.isleaf)
            {
                tempNode.myInformation.Insert(positionInsert, new Index<TK, TP>() { ID = newID, Pointer = newPointer});
                return;
            }
            Node<TK, TP> mySon = tempNode.myNode[positionInsert-1];
            if (mySon.MaxValues)
            {
                this.DivideSon(tempNode, positionInsert, mySon);
                if (newID.CompareTo(tempNode.myInformation[positionInsert].ID)>0)
                {
                    positionInsert++;
                }
            }
        }
        private void DivideSon(Node<TK, TP> nodeFather, int divideNode, Node<TK, TP> nodeToDivide)
        {
            var newNodo = new Node<TK, TP>(this.Grade);
            nodeFather.myInformation.Insert(divideNode, nodeToDivide.myInformation[this.Grade-1]);
            nodeToDivide.myNode.Insert((divideNode), newNodo);
            newNodo.myInformation.AddRange(nodeToDivide.myInformation.GetRange(this.Grade, this.Grade-1));
            nodeToDivide.myInformation.RemoveRange(this.Grade-1, this.Grade);
            if (nodeToDivide.isleaf)
            {
                newNodo.myNode.AddRange(nodeToDivide.myNode.GetRange(this.Grade, this.Grade));
                nodeToDivide.myNode.RemoveRange(this.Grade, this.Grade);
            }
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
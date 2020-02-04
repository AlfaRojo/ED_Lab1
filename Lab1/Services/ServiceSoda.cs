using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1.Helpers;
using Lab1.Models;

namespace Lab1.Services
{
    public class ServiceSoda
    {
        public Tree<Node<int>> Get()
        {
            var mySoda = new Tree<Node<int>>();


            return mySoda;
        }
        public void Post(Node<int> onTree)
        {
            Singleton.Instance.thisTree.Insert(onTree);
        }
    }
}

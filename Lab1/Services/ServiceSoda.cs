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
        public List<Soda> Get()
        {
            var mySoda = new List<Soda>();

            return mySoda;
        }
        public void Post(Soda onTree)
        {
            Singleton.Instance.thisTree.Insert(onTree);
        }
        public Tree<Soda> Get(string ID)
        {
            var mySoda = new Tree<Soda>();

            return mySoda;
        }
    }
}

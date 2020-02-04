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
        public List<Soda> Get()//Devolver valor individual
        {
            var mySoda = new List<Soda>();
            
            return mySoda;
        }
        public Tree<Soda> Get(string ID)//Devolver todos los valores
        {
            var mySoda = new Tree<Soda>();

            return mySoda;
        }
        public void Post(Soda onTree)
        {
            Singleton.Instance.thisTree.Insert(onTree);
        }
    }
}

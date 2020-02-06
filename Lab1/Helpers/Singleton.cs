using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab1.Models;


namespace Lab1.Helpers
{
    public class Singleton
    {
        private static Singleton _instance = null;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null) _instance = new Singleton();
                {
                    return _instance;
                }
            }
        }
        public Tree<int, int> thisTree = new Tree<int, int>(5);
    }
}

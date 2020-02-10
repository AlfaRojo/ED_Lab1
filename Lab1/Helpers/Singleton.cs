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
        public Tree<string, int> thisTree = new Tree<string, int>(5);
        public int pointer = 0;
        public int aux = 0;
        public List<Soda> nodeList = new List<Soda>();
        public Dictionary<int, Soda> noList { get; set; }
    }
}

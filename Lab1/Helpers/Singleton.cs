﻿using System.Collections.Generic;
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
        public Tree<Node<int>> thisTree = new Tree<Node<int>>();
    }
}

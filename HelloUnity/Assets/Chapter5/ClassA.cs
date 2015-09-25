using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter5
{
    public static class ClassA // class abstract
    {
        public static int x = 100;
        public const int y  = 100;
        public static ClassB _classB;

        static ClassA()
        {
            _classB = new ClassB();
            _classB.myName = "FromStaticInit";
        }

    }
}

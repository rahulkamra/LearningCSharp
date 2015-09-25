using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter2
{
    public class ClassA : IClassA
    {
        public ClassA(int a , int b)
        {
           
        }


        public virtual string inClass()
        {
            return "ClassA";
        }

        public string fromInterfaceOfA()
        {
            return "fromInterfaceOfA";
        }

    }
}

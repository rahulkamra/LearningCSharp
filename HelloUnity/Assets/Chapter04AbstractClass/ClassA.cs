using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter4
{
    public abstract class ClassA // class abstract
    {
        public ClassA()
        {
           
        }

        abstract public int iAmAbs(); // fnction abstract

        public abstract int myProp // property abstract
        {
            get;
        }
    }
}

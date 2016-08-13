using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;
namespace Chapter4
{
    class Chap4
    {
        //abstract classes
        public void execute()
        {
            //  ClassA classA = new ClassA(); // cannot do this , Class A is abstract

            ClassA classA = new ClassB();
            Debug.Log(ClassB.variable);
        }
    }
    
}

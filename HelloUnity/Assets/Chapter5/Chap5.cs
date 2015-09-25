using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;
namespace Chapter5
{
    class Chap5
    {
        //static classes
        public void execute()
        {
            //  ClassA classA = new ClassA(); // cannot do this , Class A is abstract

            Debug.Log(ClassA._classB.myName);
        }
    }
    
}

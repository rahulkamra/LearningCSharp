using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter2
{
    public class ClassB : ClassA,IClassB
    {
        public ClassB(int c):base(1,2)
        {
            
        }   

        override public string inClass()
        {
            return "InClassB";
        }

        public string fromInterfaceOfB()
        {
            return "fromInterfaceOfB";
        }


    }
    
}

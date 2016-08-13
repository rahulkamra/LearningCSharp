using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter4
{
    public class ClassB : ClassA
    {
        //static initializers

        public static int variable = 1;
        static ClassB()
        {
            
            variable = 10;
        }

        public ClassB()
        {
            
        }

        public override int iAmAbs() // this has to be override  . a new or a default implementation will not work
        {
            return 1;
        }

        public override  int myProp // property abstract
        {
            get
            {
                return 10;
            }
        }

      
    }
    
}

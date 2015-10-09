using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;

namespace Chapter12
{
    class Chap12
    {
        
        public void execute()   
        {
            ClassA<String> a1 = new ClassB<String>();
            ClassA<object> a2 = new ClassB<object>();

            a2 = a1;

    
        }

        public ClassB test(int x)
        {
            return new ClassB();
        }
        
    }

}

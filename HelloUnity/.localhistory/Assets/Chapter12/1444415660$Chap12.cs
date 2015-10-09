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
            ClassA<ClassC> ac = new ClassB<ClassC>();
            ClassA<ClassD> ad = new ClassB<ClassD>();

            // ad = ac;
            ad = ac;
            ac = ad;

    
        }

        public ClassB test(int x)
        {
            return new ClassB();
        }
        
    }

}

﻿using System;
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
            ClassA<string> a1 = new ClassB<ClassC>();
            ClassA<object> a2 = new ClassA<ClassS>();

            a2 = a1;

    
        }

        public ClassB test(int x)
        {
            return new ClassB();
        }
        
    }

}

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
            ClassB<ClassC> ac = new ClassB<ClassC>();
            ClassB<ClassD> ad = new ClassB<ClassD>();

            a2 = a1;

    
        }

        public ClassB test(int x)
        {
            return new ClassB();
        }
        
    }

}

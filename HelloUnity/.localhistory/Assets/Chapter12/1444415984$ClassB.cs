﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter12
{
    [MyAttrib("temo", 10)]
    public class ClassB<T> : ClassA<T>
    {
        public void getClass(T t)
        {
            
        }
    }
    
}

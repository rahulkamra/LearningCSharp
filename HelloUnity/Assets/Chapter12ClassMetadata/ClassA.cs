﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter12
{
    
    public interface ClassA<in T> 
    {
        void getClass(T t);
        
    }
}

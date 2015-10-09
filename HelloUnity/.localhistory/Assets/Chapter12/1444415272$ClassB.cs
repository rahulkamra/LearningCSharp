using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter12
{
    public class ClassB<T> : ClassA<T>
    {
        public T getClass()
        {
            return T;
        }
    }
    
}

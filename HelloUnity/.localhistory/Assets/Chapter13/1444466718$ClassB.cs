using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter13
{
    [MyAttrib("ClassB", 10)]
    public class ClassB<T> : ClassA<T>
    {
        public void getClass(T t)
        {
            
        }
    }
    
}

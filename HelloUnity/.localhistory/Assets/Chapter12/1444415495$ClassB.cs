using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter12
{
    public class ClassB<T> : ClassA<T> where T : new()
    {
        public voi getClass(T t)
        {
            return new T();
        }
    }
    
}

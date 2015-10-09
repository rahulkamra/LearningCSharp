using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter12
{
    public class ClassA<T> where T : class,new()
    {
        virtual public T getObject()
        {
            return new T();
        }

    }
}

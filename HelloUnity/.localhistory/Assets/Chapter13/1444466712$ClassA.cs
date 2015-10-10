using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter13
{
    
    public interface ClassA<in T> 
    {
        void getClass(T t);
        
    }
}

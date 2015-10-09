using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter12
{
    public class ClassA<out T>
    {
        public void printClass()
        {
            Debug.Log("Class A");
        }
    }
}

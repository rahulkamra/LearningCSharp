using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter1
{
    public class ClassA
    {
        public ClassA(int a , int b)
        {
            Debug.Log(a + "  " +  b);
        }

        public int sum(int x , int y)
        {
            return x + y;
        }

        public int sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public int sum(int x, int y, int z, int w)
        {
            return x + y + z + w;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter9
{
    public class ClassA
    {
        private int[] array = new int[10];
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
            
        }
    }
}

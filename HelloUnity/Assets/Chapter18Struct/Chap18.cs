using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using UnityEngine;

namespace Chapter18
{
    class Chap18
    {
        public void execute()   
        {
            Vector3 vector1 = new Vector3();
            Vector3 vector2 = vector1;
            vector2.x = 100;

            Debug.Log(vector1.x);// this will be zero becaucse vector3 is struct and = is a copy operation.


            int[,] x = new int[1,2]; // this is a 2d array
        }

        

    }

}

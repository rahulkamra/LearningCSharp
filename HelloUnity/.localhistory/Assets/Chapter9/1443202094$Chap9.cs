using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;
namespace Chapter9
{
    class Chap9
    {
        //indexers
        //explicit and implicit conversion

         //just for the sake of programming
        //Degree to Radian is implicit
        //Radian to Degree is explicit
        public void execute()
        {
            
            ClassA X = new ClassA();
            X[3] = 10;
            Debug.Log(X);
            
            Radian x = new Radian();
            x.value = Math.PI * 2;

            Degree degree = (Degree)x;
            Debug.Log(degree.value);

            Degree degree360 = new Degree();
            degree360.value = 360;

            Radian radian360 = degree360;//implicit
            Debug.Log(radian360.value);//2 Pi


        }
    }
    
}

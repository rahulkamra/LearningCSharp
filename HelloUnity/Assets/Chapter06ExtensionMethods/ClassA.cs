using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter6
{
    public static class ClassA
    {
        public const double DegreesToRadians = Math.PI / 180.0;
        public const double RadiansToDegrees = 180.0 / Math.PI;


        //this double means , it become an extension method of double. 
        //this can be invoked by any double
        public static double ConvertDegreeToRadians(this double degree)
        {
            return DegreesToRadians * degree;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;
namespace Chapter6
{
    class Chap6
    {
        //Extensions , injecting a method into a class
        public void execute()
        {
          
            double degree = 180;
            degree.ConvertDegreeToRadians();
            degree.printHelloWithExtension();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;
namespace Chapter2
{
    class Chap2
    {
        //function overriding and gochas
        public void execute()
        {
            ClassA _classA = new ClassA(10,100);
            ClassA _classAB = new ClassB(10);
            ClassB _classB = new ClassB(10);

            



            string resultB  = _classB.inClass();
            string resultAB_1 = _classAB.inClass();

            string resultAB_2 = (_classAB as ClassB ).inClass();

            string resultA = _classA.inClass();


            Debug.Log(resultA);
            Debug.Log(resultB);
            Debug.Log(resultAB_1);
            Debug.Log(resultAB_2);
        }
    }
    
}

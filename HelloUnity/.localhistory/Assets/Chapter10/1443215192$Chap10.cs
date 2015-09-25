using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;
namespace Chapter10
{
    class Chap10
    {
        public void execute()
        {
            ClassA c = ClassA.five;

            //this is too dangerous , as this method will exist in every object
            Debug.Log(c.toGeneratedString());

            ClassB b = new ClassB();

            b.x = 10;
            b.y = 10;
            
            testStruct(b);

            Debug.Log(b.x);
        }

        private void testStruct(ClassB b)
        {
            b.x = 50;
            b.y = 50;
            
        }
    }
    
}

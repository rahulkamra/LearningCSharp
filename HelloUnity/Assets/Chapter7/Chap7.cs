using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;
namespace Chapter7
{
    class Chap7
    {
        //out parameters , which is a way to return multiple values.
        //ref parameter , which is similar to out , but it can be used to take the input as well
        public void execute()
        {

            ClassA a = new ClassA();
            float sum;
            float subtract;
            float mul;
            float divide;
            a.doEverything(10, 15, out sum, out subtract, out mul, out divide);

            Debug.Log("sum" + sum);
            Debug.Log("subtract" + subtract);
            Debug.Log("mul" + mul);
            Debug.Log("divide" + divide);



            ClassB b = new ClassB();
            string hello = "Hello World";
            b.removeLastCharacter(ref hello);
            Debug.Log(hello);


            ClassA first = new ClassA();

            first.x = 10;
            first.y = 15;

            ClassA second = new ClassA();

            second.x = 10;
            second.y = 15;

            
            
            ClassA plus = first + second;
            Debug.Log(" + " + plus.x + " " + plus.y);

            ClassA sub = first - second;
            Debug.Log(" + " + sub.x + " " + sub.y);

            ClassA plusplus = ++first;
            Debug.Log(" + " + plusplus.x + " " + plusplus.y);
        }
    }
    
}

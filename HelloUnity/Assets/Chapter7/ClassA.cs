using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter7
{
    public class ClassA
    {
        public void doEverything(
            float x , 
            float y , 
            out float sum , 
            out float subtract ,
            out float multiply,
            out float divide)
        {
            sum = x +y;
            subtract = x - y;
            multiply = x * y;
            divide = x / y;
        }



        public int x;
        public int y;

        //All overloadable operators
        //https://msdn.microsoft.com/en-us/library/8edha89s(v=vs.71).aspx
        //overloading + 
        public static ClassA operator +(ClassA a1,ClassA a2)
        {
            ClassA result = new ClassA();

            result.x = a1.x + a2.x;
            result.y = a1.y + a2.y;

            return result;
        }

        //overloading - 
        public static ClassA operator -(ClassA a1, ClassA a2)
        {
            ClassA result = new ClassA();

            result.x = a1.x - a2.x;
            result.y = a1.y - a2.y;

            return result;
        }

        public static bool operator !(ClassA a1)
        {
            return !(a1.x != 0 && a1.y != 0);
        }

        


        //overloading ++
        public static ClassA operator ++(ClassA a1)
        {
            ClassA result = new ClassA();

            result.x = a1.x + 1;
            result.y = a1.y + 1;

            return result;
        }


        //overloading ++
        public static ClassA operator --(ClassA a1)
        {
            ClassA result = new ClassA();

            result.x = a1.x - 1;
            result.y = a1.y - 1;

            return result;
        }


        public static bool operator true(ClassA a1)
        {
            return a1.x == 0 && a1.y == 0;
        }

        public static bool operator false(ClassA a1)
        {
            return !(a1.x == 0 && a1.y == 0);
        }


    }
}

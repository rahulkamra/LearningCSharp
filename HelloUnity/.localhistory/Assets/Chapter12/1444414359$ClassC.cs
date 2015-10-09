using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter12
{
    class ClassC<T>
    {
        public delegate ClassA test(int x); 

        public void result(test x)
        {
            ClassA a = x(0);
            a.printClass();


            // Use Object for the type parameter
            ICallback<object> objCallback = new MyCallback<object>();

            // Use String for the type parameter
            ICallback<String> strCallback = new MyCallback<String>();

            // Assign from Object to String- contravariance
            strCallback = objCallback;

            // Output:
            // called, param: hello
            strCallback.call("hello");
        }


    }




}



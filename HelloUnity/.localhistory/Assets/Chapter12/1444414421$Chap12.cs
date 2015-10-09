using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;

namespace Chapter12
{
    class Chap12
    {
        
        public void execute()   
        {
            ClassA<string> a = new ClassA();
            ClassB b = new ClassB();

            ClassC<ClassA> ca = new ClassC<ClassA>();
            ca.result(test);


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

        public ClassB test(int x)
        {
            return new ClassB();
        }





    }


    // Use the 'in' keyword before the type parameter
    public interface ICallback<T>
    {
        void call(T param);
    }

    // T is declared without the 'in' keyword in implementing classes
    public class MyCallback<T> : ICallback<T>
    {
        public void call(T param)
        {
            Debug.Log("called, param: " + param);
        }
    }

}

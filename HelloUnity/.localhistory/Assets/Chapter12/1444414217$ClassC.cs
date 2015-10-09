using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
    class ClassC<T>
    {
        public delegate ClassA test(int x); 

        public void result(test x)
        {
            ClassA a = x(0);
            a.printClass();
        }


    }


    // Use the 'in' keyword before the type parameter
    public interface ICallback<in T>
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



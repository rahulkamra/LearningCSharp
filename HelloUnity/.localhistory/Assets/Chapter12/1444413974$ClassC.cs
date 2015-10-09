using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
    class ClassC<T>
    {
        public delegate ClassB test(int x); 
        public void result(test x)
        {
            return null;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
    class ClassC<in T>
    {

        public T result(T t)
        {
            return t;
        }
    }
}

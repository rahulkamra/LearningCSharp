﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
    class ClassC<T>
    {

        public T result(in T t)
        {
            return t;
        }
    }
}

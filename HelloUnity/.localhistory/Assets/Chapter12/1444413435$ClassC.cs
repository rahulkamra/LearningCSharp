﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
    class ClassC<out T>
    {

        public string toString(T t)
        {
            return t.ToString();
        }
    }
}

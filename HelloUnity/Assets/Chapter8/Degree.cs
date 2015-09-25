using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8
{
    class Degree
    {
        public double value;

        public static explicit operator Degree(Radian radian)
        {
            Degree result = new Degree();
            result.value = 360 / ((Math.PI * 2)) * radian.value;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8
{
    class Radian
    {
        public double value;

        public static implicit operator Radian(Degree degree)
        {
            Radian result = new Radian();
            result.value = ((Math.PI * 2) / 360) * degree.value;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;

namespace Chapter11
{
    class Chap11
    {
        //function overloading
        public void execute()
        {
            ClassA a = new ClassA(1,2);
            a.sum(1, 2);
            a.sum(1, 2 , 3);
            a.sum(1, 2 , 3 , 5);
        }

    }
    
}

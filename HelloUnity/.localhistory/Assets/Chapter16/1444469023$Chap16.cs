using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using UnityEngine;

namespace Chapter16
{
    class Chap16
    {

        private delegate int sum(int x, int y);
        private delegate int test(x);

        public void execute()   
        {
            sum s = delegate (int x, int y) { return x + y; };


            for(int idx = 0; idx < 10; idx++)
            {
                s(idx, idx + 1);    
            }



            //lambdas

            sum sd =  (int x, int y) => { return x + y; };

            sum sd1 = (x,y) => { return x + y; };

            sum sd2 = (x, y) => { return x + y; };

            for (int idx = 0; idx < 10; idx++)
            {
                
            }


        }
        
        
    }

}

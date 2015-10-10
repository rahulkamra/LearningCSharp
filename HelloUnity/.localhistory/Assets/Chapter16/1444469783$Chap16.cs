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
        private delegate int test(int x);

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

            test sd2 = x => { return x ; };

            test sd3 = x => x;


            List<string> li = new List<string>();

            li.Find(person => person.Contains("a"));


           // li.Find();
            pre =  (string x) => x.Contains("a");;
        }

        Predicate<string> pre;
    }

}

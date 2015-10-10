using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using UnityEngine;



namespace Chapter15
{
    class Chap15
    {
        
        public void execute()   
        {
            int x = 10; // 4 byte
            short s = 10; //2 byte
            sbyte ab = 100; // 1 byte
            long lo = 10000; // 8byte

            ulong ul = 10UL;

            decimal d = 100m;


            object o = new { a = 1 , b = 2};


            int? nullX = 1;
            int nullX2 = 1;

            bool bx = (nullX == null);
            bool bx2 = (nullX2 == null); // this will be false always.



        }
        
        
    }

}

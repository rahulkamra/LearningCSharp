using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using UnityEngine;



namespace Chapter14
{
    class Chap14
    {
        
        public void execute()   
        {
            int x = 10; // 4 byte
            short s = 10; //2 byte
            sbyte ab = 100; // 1 byte
            long lo = 10000; // 8byte

            ulong ul = 10UL;


            object o = new { a = 1 , b = 2};


            int? nullX;
            int nullX2;

            bool x = nullX == null;


        }
        
        
    }

}

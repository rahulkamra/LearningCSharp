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

            List<string> list = new List<string>();
            list.Add("1");
            list.Add("1");
            list.Add("1");
            list.Add("1");
            list.Add("1");
            list.Add("1");

            foreach(string value in list)
            {

            }



            int num = 8;
            int shiftl3 = num << 3;
            int shiftr3 = num >> 3;

            Debug.Log(shiftl3);
            Debug.Log(shiftr3);


           string hello = null";

           hello =  hello ?? "world";

            Debug.Log(hello);
        }
        
        
    }

}

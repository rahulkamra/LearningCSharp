﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using UnityEngine;

namespace Chapter17
{
    class Chap17
    {
        public void execute()   
        {
            foreach(int idx in dodo(1,2))
            {
                Debug.Log(dodo(1, 2));
            }
            for(int x = 0; x < 4; x++)
            {
                
            }
         

        }


        public IEnumerable<int> dodo(int x, int y)
        {
            
            yield return x + y;

            yield return x - y;


            yield return x * y;

            yield return x / y;
        }
    }

}

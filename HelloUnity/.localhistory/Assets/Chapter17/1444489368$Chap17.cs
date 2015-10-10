using System;
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
            IEnumerable x<int> = dodo(1, 2);
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

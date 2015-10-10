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
            foreach(int idx in dodo(1,2))
            {
                Debug.Log(idx);
            }

            IEnumerable<int> x=  dodo(1, 2);

            Debug.Log(x.ElementAt<int>(1));
            Debug.Log(x.Count<int>());

            IEnumerator<int> ien =  x.GetEnumerator();


            Debug.Log("--------");
            Debug.Log(ien.Current);
            
            bool moveNExt = ien.MoveNext();
            Debug.Log("--------");
            Debug.Log(ien.Current);
            Debug.Log("--------");
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

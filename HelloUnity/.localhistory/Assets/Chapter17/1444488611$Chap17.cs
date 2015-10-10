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

        }

        foreach (var square in PerfetSquares(100))
        {
	        Debug.Log(square);
        }

    private IEnumerable<int> PerfetSquares(int max)
    {
        var cur = 0;
        for (var i = 0; cur < max; ++i)
        {
            cur = i * i;
            yield return cur;
        }
    }
}

}

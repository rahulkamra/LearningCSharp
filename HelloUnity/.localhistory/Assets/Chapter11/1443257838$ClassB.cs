using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter11
{
    public static class ClassB
    {
        public static void removeFromList<T>(List<T> source, T item)
        {
            source.Remove(item);
        }

        public static void logList<T>(List<T> source)
        {

        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter6
{
    public static class ClassB
    {
      public static void printHelloWithExtension(this double inp)
      {
            Debug.Log(inp);  
      }
    }
    
}

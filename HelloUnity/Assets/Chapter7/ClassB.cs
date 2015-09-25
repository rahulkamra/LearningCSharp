using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter7
{
    
    public  class ClassB
    {
      public void removeLastCharacter(ref string inp)
      {
            inp =  inp.Substring(0, inp.Length - 1);
      }
    }
    
}

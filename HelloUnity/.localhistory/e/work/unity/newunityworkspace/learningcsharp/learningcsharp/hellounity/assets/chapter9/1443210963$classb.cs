using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter9
{
    public class ClassB
    {
        
        public void process(Action<string> helloAction)
        {
            helloAction("Test");
        }
            
    }
}

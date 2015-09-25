using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter9
{
    public class ClassB
    {
        public Action<string> HelloACtion;
        public void process(HelloACtion test)
        {
            helloAction("Test");
        }
            
    }
}

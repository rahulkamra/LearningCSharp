using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter12
{
   
    class MyAttrib : System.Attribute
    {

        public string name;
        public int value;

        public MyAttrib(string name , int value)
        {
            this.name = name;
            this.value = value;
        }
    }
}

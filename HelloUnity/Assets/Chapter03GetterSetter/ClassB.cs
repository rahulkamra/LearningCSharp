using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Chapter3
{
    public class ClassB : ClassA
    {
        public const string ClassB_CONST = "ClassB"; // const by default can be accessed with 
        public readonly static ClassB ClassB_RO = new ClassB();

        public ClassB()
        {
          //  this.temp2 = 19;
        }

        private int _temp;
        override public int temp
        {
            get
            {
                return _temp;
            }
            set
            {
                this._temp = value;
            }
        }

        public String Name { get; private set; }


    }
    
}

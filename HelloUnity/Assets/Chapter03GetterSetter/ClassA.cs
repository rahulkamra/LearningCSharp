using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter3
{
    public class ClassA
    {
        public ClassA()
        {
           
        }

       private int _temp;
       public virtual int temp
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




    }
}

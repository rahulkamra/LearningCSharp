using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;
namespace Chapter10
{
    class Chap9
    {
        public void execute()
        {
            ClassA a = new ClassA();
            a.addCallBack(myCallBack);

            //for regular processing , its always actions
            a.addActionCallBack(callbackAction);

            //for those callbacks whose output is more importaant
            a.addFuncCallBack(addFuncCallBack);


            a.addPredicate(isEqualToX, "x");
        }

        public void myCallBack(int x)
        {
            Debug.Log("In My CallBack");
        }

        public void callbackAction(string x)
        {
            Debug.Log(x);
        }

        public string addFuncCallBack()
        {
            return "From Chapter 9 ";
        }

        public bool isEqualToX(string from)
        {
            return from == "x";
        }
    }
    
}

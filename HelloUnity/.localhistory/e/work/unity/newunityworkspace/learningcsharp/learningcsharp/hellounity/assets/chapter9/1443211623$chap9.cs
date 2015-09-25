using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using UnityEngine;
namespace Chapter9
{
    class Chap9
    {
        public void execute()
        {
            ClassA a = new ClassA();
            a.addCallBack(myCallBack);

            a.addActionCallBack(callbackAction);
            
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
            return "From Chapter 9 "
        }
    }
    
}

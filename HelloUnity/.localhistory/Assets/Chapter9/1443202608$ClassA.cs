﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter9
{
    public class ClassA
    {

        public delegate void TestCallBack(int a);
        public del next;
        public void ExecuteNext()
        {
            next();
        }

        public void addCallBack(TestCallBack test)
        {
            test(10);
        }
    }
}

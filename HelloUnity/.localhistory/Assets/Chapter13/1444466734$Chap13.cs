﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;
using System.Reflection;
using UnityEngine;

namespace Chapter13
{
    class Chap13
    {
        
        public void execute()   
        {
            ClassA<ClassC> ac = new ClassB<ClassC>();
            ClassA<ClassD> ad = new ClassB<ClassD>();

            // ad = ac;
            ad = ac; // this works because its (in) keyword which means only in params are accepted which means the super class can come in base class, 
                     //ac = ad;


            System.Reflection.MemberInfo info = typeof(Chapter12.ClassB<>);
            object[] attributes = info.GetCustomAttributes(true);


            Debug.Log(attributes.Count());
            MyAttrib my = typeof(ClassB<>).GetCustomAttributes(typeof(MyAttrib), true).FirstOrDefault() as MyAttrib;

            
            Debug.Log(my.name);
        }

        public ClassB test(int x)
        {
            return new ClassB();
        }
        
    }

}
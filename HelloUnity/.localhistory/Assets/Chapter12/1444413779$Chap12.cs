using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter1;

namespace Chapter12
{
    class Chap12
    {
        
        public void execute()   
        {
            ClassA a = new ClassA();


            ClassC<ClassB> ba = new ClassC<ClassB>();
            a =  ba.result();



        }



    }
    
}

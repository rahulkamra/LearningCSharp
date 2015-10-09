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
            ClassB b = new ClassB();


            ClassC<ClassA> ca = new ClassC<ClassA>();
            
        }

        public ClassB test(int x)
        {
            return new ClassA();
        }





    }
    
}

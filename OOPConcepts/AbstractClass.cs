using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    abstract class AbstractClass
    {
        // without abstract method is called 
        public void withoutAbstract()
        {
            Console.WriteLine("Without abstract base method is called");
        }
       
        // if abstract method then class should be abstract and must implement in child class. 
        public abstract void withAbstractMethod();
         
    }

    class childAbstract : AbstractClass
    {

        public override void withAbstractMethod()
        {
            Console.WriteLine("abstract child method is called");
        }
    }
}

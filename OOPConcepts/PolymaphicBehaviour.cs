using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public class BaseClass
    {
        //Base constructor is called first......
        public BaseClass()
        {
          
            Console.WriteLine("Base.....");
        }
        // base paramerterrized constructor called first if its inherit in child class like in please see in childclass
        public BaseClass(string name)
        {
            Console.WriteLine("P Base....." + name);
        }
        public virtual void overrideMethod()
        {
            Console.WriteLine("base override method is called");
        }
        public virtual void virtualwithoutoverride()
        {
            Console.WriteLine("base virtualwithoutoverride method is called");
        }
        public virtual void newMethod()
        {
            Console.WriteLine("newMethod from base is called");
        }
    }
    public class ChildClass : BaseClass
    {
        //first call base constructor than called child constructor
        public ChildClass()
        {
            Console.WriteLine("Child.....");
        }
        // first called base parameterrized constructor than called child constructor
        public ChildClass(string name) : base(name)
        {
            Console.WriteLine("p Child....." + name);
        }
        // override method called when virtual in base class. 
        public override void overrideMethod()
        {
            Console.WriteLine("child override method is called");
        }
        // this method is hide if with new keyword. and called base method.
        public new void newMethod()
        {
            Console.WriteLine("child newMethod method is called");
        }
    } 
}

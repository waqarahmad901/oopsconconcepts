using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.DesingPatterns.AdapterPattern
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Duck: I'm flying");
        }

        public void Quack()
        {
            Console.WriteLine("Duck: Quack Quack Quack");

        }
    }
}

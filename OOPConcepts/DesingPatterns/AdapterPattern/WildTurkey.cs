using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.DesingPatterns.AdapterPattern
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Duck: I'm flying short distance");
        } 
        public void Gobble()
        {
            Console.WriteLine("Turkey: Gobble Gobble Gobble"); 
        }
    }
}

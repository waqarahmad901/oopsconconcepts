using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{

   static class  StaticConstructor
    {
       const int constex = 10;
       public static readonly int readonlyex = 10;
        public static int a { get; set; }
        //  a static constructor is useful for initializing any static fields associated with a type 
        //(or any other per-type operations) - useful in particular for reading required configuration data
        //into readonly fields, etc. It is run automatically by the runtime the first time it is needed
        //(the exact rules there are complicated (see "beforefieldinit"), and changed subtly between CLR2 and CLR4). 
        //Unless you abuse reflection, it is guaranteed to run at most once(even if two threads arrive at the same time).
        static StaticConstructor()
        {
            a = 10;
            readonlyex = 20; 
            
        }

    }
}

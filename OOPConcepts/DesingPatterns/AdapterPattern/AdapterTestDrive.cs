using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*THe adapter Pattern:

    Convert interface of class
    into another Interface the client expect. 
    classes work togather that couldn't otherwise
    because of incompitible interface.
*/
namespace OOPConcepts.DesingPatterns.AdapterPattern
{
    public class AdapterTestDrive
    {
        public static void AdapterTest()
        {
            
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The thurkey says.....");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("The Duck says.....");
            duck.Quack();
            duck.Fly();

            Console.WriteLine("The thurkeyAdapter says.....");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.AbstractFactory
{
    class WahFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}

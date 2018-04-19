using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.DesingPatterns.DecoratorPattern
{
    public interface IBakeryComponent
    {
        string GetName();
         double GetPrice();
    }
}

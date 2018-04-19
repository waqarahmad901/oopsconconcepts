using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace OOPConcepts.NinjetDI
{
    public class Binding : NinjectModule
    {
        public override void Load()
        {

            Bind<IWeapon>().To<Ninja>();
            Bind<ILogging>().To<Logging>();
        }
    }
}

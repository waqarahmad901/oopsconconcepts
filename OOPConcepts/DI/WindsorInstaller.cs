using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using OOPConcepts.NinjetDI;

namespace OOPConcepts.DI
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ILogging>().ImplementedBy<Logging>());
            container.Register(Component.For<IWeapon>().ImplementedBy<Ninja>());

          
        }
    }
}

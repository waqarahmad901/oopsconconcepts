using System;

namespace OOPConcepts.NinjetDI
{
    public class Ninja : IWeapon
    {
        private readonly ILogging logging; 
        public Ninja(ILogging logging)
        {
            this.logging = logging;
        }
        public void sord()
        {
            logging.Debug("logging debug is called");
            Console.WriteLine("sord is called");
        }
    }
}
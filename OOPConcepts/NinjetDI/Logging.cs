using System;

namespace OOPConcepts.NinjetDI
{
    public class Logging : ILogging
    {
        public void Debug(string message)
        {
            Console.WriteLine(message);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.DI
{
    public class OperationEvent
    {
        IErrorLogger logger;

        public OperationEvent(IErrorLogger logger)
        {
            this.logger = logger;
        }

        public void Division()
        {
            try
            {
                int firstNumber = 15, secondNumber = 0, result;
                result = firstNumber / secondNumber;
                Console.WriteLine("Result is :{0}", result);
            }
            catch (DivideByZeroException ex)
            {
                logger.LogMessage(ex);
            }
        }
    }
}

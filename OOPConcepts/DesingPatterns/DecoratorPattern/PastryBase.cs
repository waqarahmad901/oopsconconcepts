using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.DesingPatterns.DecoratorPattern
{
    public class PastryBase : IBakeryComponent
    {
        private string m_Name = "Pastry ";
        private double m_Price = 200.0;

        public string GetName()
        {
            return m_Name;
        } 
        public double GetPrice()
        {
            return m_Price;
        }
    }
}

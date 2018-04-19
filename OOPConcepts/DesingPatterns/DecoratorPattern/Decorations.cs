using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.DesingPatterns.DecoratorPattern
{
    public class ArtificialScent : Decorator
    {
        public ArtificialScent(IBakeryComponent baseComponent) : base(baseComponent)
        {
            this.m_Name = "Artificial Scent";
            this.m_Price = 3.0;
        }
    }
    class CherryDecorator : Decorator
    {
        public CherryDecorator(IBakeryComponent baseComponent) : base(baseComponent)
        {
            this.m_Name = "Cherry";
            this.m_Price = 2.0;
        }
    }

    class CreamDecorator : Decorator
    {
        public CreamDecorator(IBakeryComponent baseComponent) : base(baseComponent)
        {
            this.m_Name = "Cream";
            this.m_Price = 1.0;
        }
    }

    // decorator with discoiunt
    class NameCardDecorator : Decorator
    {
        private int m_DiscountRate = 5;

        public NameCardDecorator(IBakeryComponent baseComponent) : base(baseComponent)
        {
            m_Name = "Name Card";
            m_Price = 4.0;
        }

        public override string GetName()
        {
            return base.GetName() +
                string.Format("\n(Please Collect your discount card for {0}%)",
                m_DiscountRate);
        }
    }
}


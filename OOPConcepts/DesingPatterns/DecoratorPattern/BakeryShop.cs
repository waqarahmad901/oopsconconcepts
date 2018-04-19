using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 The Decorator Pattern attaches additional responsibilities to an object dynamically.
 Decorators provide a ﬂexible alternative to subclassing for extending functionality.

     */
namespace OOPConcepts.DesingPatterns.DecoratorPattern
{
    public class BakeryShop
    {
        public static void OrderCakeWithCreamCherryScent()
        {
            CakeBase cBase = new CakeBase();
            PrintProductDetails(cBase);

            // Lets add cream to the cake
            CreamDecorator creamCake = new CreamDecorator(cBase);
            PrintProductDetails(creamCake);

            // Let now add a Cherry on it
            CherryDecorator cherryCake = new CherryDecorator(creamCake);
            PrintProductDetails(cherryCake);

            // Lets now add Scent to it
            ArtificialScent scentedCake = new ArtificialScent(cherryCake);
            PrintProductDetails(scentedCake);

            // Finally add a Name card on the cake
            NameCardDecorator nameCardOnCake = new NameCardDecorator(scentedCake);
            PrintProductDetails(nameCardOnCake);

            // Lets now create a simple Pastry
        

        }

        public static void OrderPastryWithCream()
        {
            PastryBase pastry = new PastryBase();
            PrintProductDetails(pastry);

            // Lets just add cream and cherry only on the pastry 
            CreamDecorator creamPastry = new CreamDecorator(pastry);
            CherryDecorator cherryPastry = new CherryDecorator(creamPastry);
            PrintProductDetails(cherryPastry);
        }

        private static void PrintProductDetails(IBakeryComponent cBase)
        {
            Console.WriteLine(string.Format("Item: {0}, Price: {1}", cBase.GetName(), cBase.GetPrice()));
        }
    }

}

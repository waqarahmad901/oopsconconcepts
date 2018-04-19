using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Ninject;
using OOPConcepts.AbstractFactory;
using OOPConcepts.DesingPatterns.AdapterPattern;
using OOPConcepts.DesingPatterns.DecoratorPattern;
using OOPConcepts.DI;
using OOPConcepts.NinjetDI;

namespace OOPConcepts
{


    class Program
    {
        static void Main(string[] args)
        {

            //Abstract factory pattern

            ContinentFactory factory = new LahoreFactory();
            AnimalWorld world = new AnimalWorld(factory);
            world.RunFoodChain();

            // decoratoer pattern
            BakeryShop.OrderCakeWithCreamCherryScent();
            BakeryShop.OrderPastryWithCream();
            AdapterTestDrive.AdapterTest();

            //When using Dependency Injection, objects are given their dependencies on run time 
            //rather than compile time.In other words objects 
            //are configured by an external entity.

           // ninjet DI 
           var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var wap = kernel.Get<IWeapon>();
            wap.sord(); 

            //castle windsor DI
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            var root = container.Resolve<IWeapon>();

            root.sord();

            //simple DI
      //      OperationEvent objOperationEvent = new OperationEvent(new FileLogger());
      //      objOperationEvent.Division();
     //       Console.Read();
            // static constructor behivour. 
            var iii = StaticConstructor.a;

            // polymarphism behivour......
            BaseClass aa = new ChildClass("waqar");
            ChildClass bb = new ChildClass();

            aa.overrideMethod();
            aa.newMethod();
            bb.newMethod();
            aa.virtualwithoutoverride();

            // abstract class behivour;
            childAbstract aClass = new childAbstract();
            aClass.withoutAbstract();
            aClass.withAbstractMethod();

            GetSecondHeightNumber(new int[] { 5, 11, 12, 16, 54, 54, 55, 99, 55, 22, 98, 98, 99, 99, 99, 88, 10, 15 });
            SimpleBubbleSort(new int[] { 3, 60, 35, 2, 45, 320, 5 });

            int[] arr = { 10, 64, 7, 52, 32, 18, 2, 48 };
            HeapSort hs = new HeapSort();
            hs.PerformHeapSort(arr);


            Console.ReadKey();

            //Encapsulation
            // List<string> list = new List<string>();
            // list.Sort(); /* Here, which sorting algorithm is used and hows its 
            // implemented is not useful to the user who wants to perform sort, that's 
            // why its hidden from the user of list. */

            //Abstraction: Is a way of providing generalization and hence a common way 
            //to work with objects of vast diversity. e.g.
        }

        public static void GetSecondHeightNumber(int[] arr)
        {
            int first = 0;
            int second = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }

            Console.WriteLine(second);
        }

        public static void SimpleBubbleSort(int[] a)
        {
            bool done = false;
            while (!done)
            {
                done = true;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        done = false;
                    }
                }
            }

            Console.Write(string.Join(",", a));

        }


    }

    class HeapSort
    {
        private int heapSize;

        public int BuildHeap(string[] aa)
        {
            return 1;
        }

        private void BuildHeap(int[] arr)
        {
            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        private void Swap(int[] arr, int x, int y)//function to swap elements
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void Heapify(int[] arr, int index)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && arr[left] > arr[index])
            {
                largest = left;
            }

            if (right <= heapSize && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(arr, index, largest);
                Heapify(arr, largest);
            }
        }
        public void PerformHeapSort(int[] arr)
        {
            BuildHeap(arr);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0);
            }
            DisplayArray(arr);
        }
        private void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            { Console.Write("[{0}]", arr[i]); }
        }
    }
}

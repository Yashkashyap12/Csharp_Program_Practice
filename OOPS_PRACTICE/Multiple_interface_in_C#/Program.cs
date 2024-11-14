using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_interface_in_C_
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface 
    {
        void myOtherMethod(); // interface method
    }

    // implement multiple interfaces 
    class DemoClass : IFirstInterface , ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("some text");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("some other text...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass demo = new DemoClass();
            demo.myMethod();
            demo.myOtherMethod();

            Console.ReadLine();
        }
    }
}

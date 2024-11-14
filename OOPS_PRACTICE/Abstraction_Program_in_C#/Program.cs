using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Program_in_C_
{
    abstract class Animal // abstract class
    {
        public abstract void animalsound(); //abstract method (doesn't have a body)
        
        //regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("The Pig says : wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig mypig = new Pig(); // Create a Pig object
            mypig.animalsound(); // Call the abstract method
            mypig.sleep();  // Call the regular method

            Console.ReadLine();
        }
    }
}

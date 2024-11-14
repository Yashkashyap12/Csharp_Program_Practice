using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_C_
{
    interface IAnimal // Interface
    {
        void animalsound(); // interface method (doesn't have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalsound()
        {
            Console.WriteLine("The Pig says : wee wee");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig mypig = new Pig(); // create a pig object 
            mypig.animalsound();

            Console.ReadLine();
        }
    }
}

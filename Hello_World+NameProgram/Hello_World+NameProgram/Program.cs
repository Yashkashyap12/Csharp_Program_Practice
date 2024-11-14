using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World_NameProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name :");
            string username = Console.ReadLine();
            Console.WriteLine("Raadhe Raadhe : " + username);
            Console.ReadKey();
        }
    }
}

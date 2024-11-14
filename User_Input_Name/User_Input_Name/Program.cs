using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter Your Name :");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Raadhe Raadhe : "+ name);
            Console.ReadLine();
            
        }
    }
}

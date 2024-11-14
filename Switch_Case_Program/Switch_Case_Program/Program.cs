using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your number : ");
            int usernum = int.Parse(Console.ReadLine());

            switch (usernum)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your number is {0}", usernum);
                    break;
                default:
                    Console.WriteLine("Your number is not 1,2 & 3");
                    break;
            }
            Console.ReadLine();
        }
    }
}

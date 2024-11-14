using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Enter your Digit :");
            int userRequest=Convert.ToInt32(Console.ReadLine());
                for(b=1;b<11;b++) 
                {
                    Console.WriteLine(userRequest + "*"+ b +"="+ userRequest * b);
                }
                Console.WriteLine();
            Console.ReadLine();
        }
    }
}

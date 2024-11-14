using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Option_Choosing_in_Cafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name :");
            string user = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Welcome To Our Cafe : " + user);
            Console.WriteLine("Please Select Your Choice");
            Console.WriteLine("1:Tea");
            Console.WriteLine("2:Coffee");
            Console.WriteLine("3:MilkShake");
            Console.WriteLine("4:No Thanks !");
            string choice = Convert.ToString(Console.ReadLine());
            switch (choice)
            {
                case "1": Console.WriteLine("Tea");
                    break;
                case "2":
                    Console.WriteLine("Coffee");
                    break;
                case "3":
                    Console.WriteLine("Milkshake");
                    break;
                case "4": Console.WriteLine("No Thanks!");
                    break;
            };
            if (choice == "4")
            {
                Console.WriteLine("Visit Again! " + DateTime.Now);
            }
            else if (choice != "1" && choice != "2" && choice != "3") 
            {
                Console.WriteLine("Invalid choice," + user + " please try again!" + DateTime.Now);
            }
            else
            {
                Console.WriteLine("Please Wait Your Order is Ready in 5 minutes... " + DateTime.Now);
            }

            Console.ReadLine();
        }
    }
}


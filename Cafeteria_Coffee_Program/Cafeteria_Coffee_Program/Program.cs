using System;

namespace Cafeteria_Coffee_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalamount = 0;
        Start:
            Console.WriteLine("----: Please Select Coffee Name :---- ");
            Console.WriteLine("1 : CAPACINO\n2 : CHOCOLATE\n3 : DARK CHOCO HOT COFFEE\n");
            string userchoice = Console.ReadLine();
            int a;
            int b;
            try
            {
                a = int.Parse(userchoice);
                switch (userchoice)
                {
                    case "1":
                        Console.WriteLine("Your Selected Option is {0} \n ", userchoice);
                        break;
                    case "2":
                        Console.WriteLine("Your Selected Option is {0} \n", userchoice);
                        break;
                    case "3":
                        Console.WriteLine("Your Selected Option is {0} \n", userchoice);
                        break;
                    case "4":
                        Console.WriteLine((userchoice != "4" || userchoice != "5" || userchoice != "6"));
                        Console.WriteLine("Your Choice is Invalid!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice Please Select Again...");
                        goto Start;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("OOPS!, You Have Not Enerted a Valid Value");
                goto Start;
            }


        restart:
            Console.WriteLine("----: Please Select Coffee Size :----");
            Console.WriteLine("1: Small Rate is : 20 \n2 : Medium Rate is : 30 \n3 : Large Rate is : 35 ");
            string userchoicename = Console.ReadLine();
            try
            {
                b = int.Parse(userchoicename);
                switch (userchoicename)
                {
                    case "1":
                        Console.WriteLine("Your Selected Option is {0} \n", userchoicename);
                        totalamount += 20;
                        break;
                    case "2":
                        Console.WriteLine("Your Selected Option is {0} \n", userchoicename);
                        totalamount += 30;
                        break;
                    case "3":
                        Console.WriteLine("Your Selected Option is {0} \n", userchoicename);
                        totalamount += 35;
                        break;
                    case "4":
                        Console.WriteLine((userchoice != "4" || userchoice != "5" || userchoice != "6"));
                        Console.WriteLine("Your Choice is Invalid!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Selected Size !!..");
                        goto restart;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("OOPS!, You Have Not Enerted a Valid Value");
                goto Start;
            }

            Console.WriteLine("Your Order is Ready within 5 minutes Please Wait... ");
            Console.WriteLine("Your Total Amount is : {0} ", totalamount);
        selectagain:
            Console.WriteLine("Do you want to Buy Anything Else so write : Yes or No ");
            string userselectoption = Console.ReadLine();

            switch (userselectoption.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    Console.WriteLine("Please Pay Your Bill On The Cash Counter...");
                    Console.WriteLine("Visit Again Hope You Liked Our Service...\nThank You... ");
                    break;
                default:
                    Console.WriteLine("Your Choice is Invalid. Please Try Again...");
                    goto selectagain;

            }

            Console.ReadLine();
        }
    }
}

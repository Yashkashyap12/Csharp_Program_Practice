using System;

namespace Calculator_Program_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Enter Your First Digit : ");
            string val_1 = Console.ReadLine();
            Console.WriteLine("Enter Your Second Digit : ");
            string val_2 = Console.ReadLine();
            try
            {
                a = int.Parse(val_1);
                
            }
            catch (Exception)
            {
                Console.Write("Opps, You have not enerted valid value");
                Console.ReadKey();
            }
            try
            {
                b = int.Parse(val_2);

            }
            catch (Exception)
            {
                Console.Write("Opps, You have not enerted valid value");
                Console.ReadKey();
            }
            Console.WriteLine("Select Your Operator : ");
            Console.WriteLine("Add : + ");
            Console.WriteLine("Subtract : - ");
            Console.WriteLine("Multiply : * ");
            Console.WriteLine("Divide : / ");
            string op = Console.ReadLine();
            Console.WriteLine("Your Selected Operator : " + op);
            int result = 0;
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            Console.WriteLine("Your Result is : " + result);
            Console.ReadLine();
        }
    }
}

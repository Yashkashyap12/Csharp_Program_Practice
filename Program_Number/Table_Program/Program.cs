using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter the Number : ");
            int j = Convert.ToInt32(Console.ReadLine());
            for(i=j;i<11;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

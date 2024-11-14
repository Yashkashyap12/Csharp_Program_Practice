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
            int a = 0;
            int b = 0;
            for(a = 1; a < 11; a++)
            {
                Console.WriteLine("table for "+ a);
                for (b=1; b < 11; b++) 
                {
                    
                    Console.WriteLine(a + "*" + b +"="+ a * b );
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}

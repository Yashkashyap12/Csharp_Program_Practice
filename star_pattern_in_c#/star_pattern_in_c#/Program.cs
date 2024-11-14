using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_pattern_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, col, num;
            Console.WriteLine("Enter character which pattern you want : ");
            num = int.Parse(Console.ReadLine());//5

            for(row = 1; row <= num; row++)//1 2 3 4
            {
                for(col = 1; col <= row; col++)//1 2 3 4
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

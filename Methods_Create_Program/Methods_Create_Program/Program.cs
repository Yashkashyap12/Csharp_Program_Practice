using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Create_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----HOW TO CALL THE METHOD WITHOUT STATIC----//
            //Program p = new Program();
            //p.EvenOddProgram();
            //----HOW TO CALL THE METHOD WITH STATIC----//
            Program.EvenOddProgram(20);//gives parameter 

            Program P = new Program();
            int Sum = P.Add(10, 20);
            Console.WriteLine("Sum = {0}",Sum);
            Console.ReadLine();
            
        }


        //------CREATE ADD METHOD------//
        public int Add(int fn, int sn)
        {
            return fn + sn;
        }
        


        //------CREATE EVENODD METHOD------//
        public static void EvenOddProgram(int target)//declare parameter
        {
            int start = 0;
            while(start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Parameters_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            SimpleMethod(ref i);//Pass By Reference

            //int i = 0;
            //SimpleMethod(i);//Pass By Value

            Console.WriteLine(i);
            Console.ReadLine();
        }

        //----PASS BY VALUE----//
        //public static void SimpleMethod(int j)
        //{
        //    j = 101;
        //}

        //----PASS BY REFERENCE----//
        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }
    }
}

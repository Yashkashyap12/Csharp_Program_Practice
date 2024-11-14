using System;

namespace For_loop_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;

            //--------FOREACH LOOP--------//
            foreach (int k in arr)
            {
                Console.WriteLine(k);
            }

            //--------FOR LOOP--------//
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //--------WHILE LOOP--------//
            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                i++;
            }

            //--------CONTINUE LOOP--------//
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
            }


            //--------BREAK LOOP--------//
            for (int i = 0; i <= 20; i++)
            {
                if (i == 10)
                    break;
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

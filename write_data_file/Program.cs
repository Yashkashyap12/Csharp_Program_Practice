using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace write_data_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\Yash.txt";
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine("Hello Yash how are you" + DateTime.Now.ToString());
            }
        }
    }
}

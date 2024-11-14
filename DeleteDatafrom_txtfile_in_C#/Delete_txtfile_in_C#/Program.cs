using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDatafrom_txtfile_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\File.txt";
            File.Delete(fileName);
             
        }
    }
}

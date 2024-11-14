using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Create_Text_File_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName =@"D:\Yash.txt";
            File.Create(fileName);
        }
    }
}

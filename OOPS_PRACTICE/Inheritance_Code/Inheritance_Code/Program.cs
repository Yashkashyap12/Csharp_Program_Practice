using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Code
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
         
    }
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }
    public class PartTimeEmployee : FullTimeEmployee
    {
        public float HourlyRate;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee FTE = new PartTimeEmployee();
            FTE.FirstName = "Radha";
            FTE.LastName = "Rani";
            FTE.YearlySalary = 50000;
            FTE.HourlyRate = 100000;
            Console.WriteLine(FTE.FirstName + " " + FTE.LastName +" " + FTE.HourlyRate + " " + FTE.YearlySalary);
            Console.ReadLine();
        }
    }
    
}

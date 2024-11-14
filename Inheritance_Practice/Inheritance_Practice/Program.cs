using System;

namespace Inheritance_Practice
{
    internal class Program
    {
        class VisitingEmployee : Employees
        {
            public int VisitingSalary;
            public int VisitingHours;
        }
        class PermanentEmployee : Employees
        {
            public int PermanentSalary;
            public int PermanentHours;
        }
        class Employees
        {
            public int EmployeeID;
            public string EmpName;
            public int EmpAge;
            public int EmpContactNumber;

            static void Main(string[] args)
            {
                PermanentEmployee PE = new PermanentEmployee();
                PE.EmployeeID = 1;
                PE.EmpName = "Radha Rani";

                VisitingEmployee VE = new VisitingEmployee();
                VE.EmployeeID = 2;
                VE.EmpName = "Banke Bihari";

                Console.WriteLine(PE.EmpName);
                Console.WriteLine(VE.EmpName);
                Console.ReadLine();
            }
        }
    }
}

using System;

namespace EmployeeUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Employee = 1;
            int EmployeeWage = 0;

            if (Employee == 1)
            {
                Console.WriteLine("Employee is present");
                EmployeeWage = 238 * 12;
                Console.WriteLine("EmployeeWage = " + EmployeeWage);
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("No Wages calculated");
            }
        }

                
    }
}

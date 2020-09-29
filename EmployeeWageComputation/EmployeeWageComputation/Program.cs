using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int isPresent = 1;
            const int empRatePerHour = 20;
            int empHours;
            int empWage;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isPresent)
            {
                Console.WriteLine("Employee is Present");
                empHours = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHours = 0;
            }
            empWage = empHours * empRatePerHour;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}

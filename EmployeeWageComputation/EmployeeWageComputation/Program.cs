using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            const int isPresent = 1;
            const int empRatePerHour = 20;
            const int FULLTIME = 1;
            int empHours;
            int empWage;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isPresent)
            {
                int isFullOrPartTime = random.Next(0, 2);
                if (isFullOrPartTime == FULLTIME)
                    empHours = 8;
                else
                    empHours = 4;
            }
            else
                empHours = 0;
            empWage = empHours * empRatePerHour;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}

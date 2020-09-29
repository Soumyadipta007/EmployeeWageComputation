using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int empWage;
            const int empRatePerHour = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            int empHours = getEmpHours(empCheck);
            empWage = empHours * empRatePerHour;
            Console.WriteLine("Employee Wage : " + empWage);
        }
        public static int getEmpHours(int empCheck)
        {
            int empHours = 0;
            const int FULLTIME = 1;
            const int PARTTIME = 0;
            const int PRESENT = 1;
            const int ABSENT = 0;
            Random random = new Random();
            switch (empCheck)
            {
                case PRESENT:
                    int isFullOrPartTime = random.Next(0, 2);
                    switch (isFullOrPartTime)
                    {
                        case FULLTIME:
                            empHours = 8;
                            break;
                        case PARTTIME:
                            empHours = 4;
                            break;
                    }
                    break;
                case ABSENT:
                    empHours = 0;
                    break;
            }
            return empHours;
        }
    }
}

using System;

namespace EmployeeWageComputation
{
    class Program
    {
        const int EMP_RATE_PER_HOUR = 20;
        const int TOTAL_HOURS = 100;
        const int TOTAL_DAYS = 20;
        const int FULLTIME = 1;
        const int PARTTIME = 2;
        const int ABSENT = 0;
        public static void computeEmpWage()
        {
            int countOfHours = 0;
            int countOfDays = 0;
            int totalWage = 0;
            Random random = new Random();
            int isFullOrPartTime;
            int empHours = 0;
            while (countOfHours <= TOTAL_HOURS && countOfDays < TOTAL_DAYS)
            {
                isFullOrPartTime = random.Next(0, 3);
                switch (isFullOrPartTime)
                {
                    case FULLTIME:
                        empHours = 8;
                        break;
                    case PARTTIME:
                        empHours = 4;
                        break;
                    case ABSENT:
                        empHours = 0;
                        break;
                }
                totalWage = totalWage + (empHours * EMP_RATE_PER_HOUR);
                countOfHours += empHours;
                countOfDays += 1;
            }
            Console.WriteLine("Employee total Wage: " + totalWage);
        }
        static void Main(string[] args)
        {
            computeEmpWage();            
        }
    }
}

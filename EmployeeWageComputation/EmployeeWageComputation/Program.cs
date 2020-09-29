using System;

namespace EmployeeWageComputation
{
    class Program
    {
        const int FULLTIME = 1;
        const int PARTTIME = 2;
        const int ABSENT = 0;
        public static void computeEmpWage(string company,int EMP_RATE_PER_HOUR,int totalHours, int totalDays)
        {
            int countOfHours = 0;
            int countOfDays = 0;
            int totalWage = 0;
            Random random = new Random();
            int isFullOrPartTime;
            int empHours = 0;
            while (countOfHours <= totalHours && countOfDays < totalDays)
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
            Console.WriteLine("Total Employee Wage for company " +company+" :"+ totalWage);
        }
        static void Main(string[] args)
        {
            computeEmpWage("Dmart",20,100,20);
            computeEmpWage("Reliance", 20, 200, 30);
        }
    }
}

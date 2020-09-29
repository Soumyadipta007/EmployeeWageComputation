using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int isFullOrPartTime;
            int empHours = 0;
            const int empRatePerHour = 20;
            const int FULLTIME = 1;
            const int PARTTIME = 2;
            const int ABSENT = 0;
            int dailyWage = 0;
            int monthlyWage = 0;
            for (int i = 0; i <= 20; i++)
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
                dailyWage = empHours * empRatePerHour;
                monthlyWage += dailyWage;
            }
            Console.WriteLine("Employee Monthly Wage: " + monthlyWage);
        }
    }
}

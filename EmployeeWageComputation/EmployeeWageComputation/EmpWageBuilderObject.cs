using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWageBuilderObject
    {
        private string company;
        private int EMP_RATE_PER_HOUR;
        private int totalHours;
        private int totalDays;
        private int totalWage;
        const int FULLTIME = 1;
        const int PARTTIME = 2;
        const int ABSENT = 0;
        public EmpWageBuilderObject(string company, int EMP_RATE_PER_HOUR, int totalHours, int totalDays)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.totalHours = totalHours;
            this.totalDays = totalDays;
        }
        public void computeEmpWage()
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
            Console.WriteLine("Total Employee Wage for company " + company + " :" + totalWage);
        }
        public string toString()
        {
            return ("Total Emp Wage for company "+this.company+" is: "+this.totalWage);
        }
    }
}

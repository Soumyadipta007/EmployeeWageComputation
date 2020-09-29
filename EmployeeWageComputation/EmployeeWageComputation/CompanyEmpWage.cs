using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int totalHours;
        public int totalDays;
        public int totalWage;
        public CompanyEmpWage(string company, int empRatePerHour, int totalHours, int totalDays)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.totalHours = totalHours;
            this.totalDays = totalDays;
        }
        public void setTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
        public string toString()
        {
            return ("Total Employee wage for company " + this.company + " is: " + this.totalWage);
        }
    }
}

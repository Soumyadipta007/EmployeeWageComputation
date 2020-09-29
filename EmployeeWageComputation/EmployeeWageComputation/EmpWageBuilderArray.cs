using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWageBuilderArray
    {
        const int FULLTIME = 1;
        const int PARTTIME = 2;
        const int ABSENT = 0;
        private int numCompany = 0;
        private List<CompanyEmpWage> companyEmpWageList;
        public EmpWageBuilderArray()
        {
            this.companyEmpWageList = new List<CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int totalHours, int totalDays)
        {
            companyEmpWageList.Add(new CompanyEmpWage(company,empRatePerHour,totalHours,totalDays));
            numCompany++;
        }
        public void computeEmpWage()
        {
            for(int i = 0; i < numCompany; i++)
            {
                companyEmpWageList[i].setTotalWage(this.computeEmpWage(this.companyEmpWageList[i]));
                Console.WriteLine(this.companyEmpWageList[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int countOfHours = 0;
            int countOfDays = 0;
            int totalWage = 0;
            Random random = new Random();
            int isFullOrPartTime;
            int empHours = 0;
            while (countOfHours <= companyEmpWage.totalHours && countOfDays < companyEmpWage.totalDays)
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
                totalWage = totalWage + (empHours * companyEmpWage.empRatePerHour);
                countOfHours += empHours;
                countOfDays += 1;
            }
            return totalWage;
        }
    }
}

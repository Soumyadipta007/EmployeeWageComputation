using System;

namespace EmployeeWageComputation
{
    class Program
    {
        const int FULLTIME = 1;
        const int PARTTIME = 2;
        const int ABSENT = 0;
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 100, 20);
            empWageBuilder.addCompanyEmpWage("Reliance", 20, 200, 30);
            empWageBuilder.computeEmpWage();
        }
    }
}

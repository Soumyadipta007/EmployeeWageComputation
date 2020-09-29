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
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart",20,100,20);
            EmpWageBuilderObject Reliance = new EmpWageBuilderObject("Reliance", 20, 200, 30);
            dmart.computeEmpWage();
            dmart.toString();
            Reliance.computeEmpWage();
            Reliance.toString();
        }
    }
}

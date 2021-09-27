using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagesUsingOOPS
{
    class MainMethodClass
    {
         static void Main(string[] args)
         {
            //UC1_PresentOrAbsent obj1 = new UC1_PresentOrAbsent();
            //obj1.CheckEmp();

            //UC2_CalculateWages obj2 = new UC2_CalculateWages();
            //obj2.DailyWages();

            //UC3_AddPartTime obj3 = new UC3_AddPartTime();
            //obj3.AddPartTimeEmp();

            //UC4_EmpWageUsingSwitchCase obj4 = new UC4_EmpWageUsingSwitchCase();
            //obj4.EmpWageUsingSwitchCase();

            UC5_EmpWagesWorkingInMonth obj5 = new UC5_EmpWagesWorkingInMonth();
            obj5.EmpWagesWorkingInMonth();
         }
    }
}

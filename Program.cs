using day4.uc10;
using day4.uc9;
using day4.ucFinal_Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class program
    {
       public static void Main(string[] args)
        {
            uc1_EmployeeAttendance.Main1();
            uc2_EmployeeWage.Main2();
            uc3_PartTimeEmpWage.Main3();
            uc4_EmployeeWageUsingSwitch.Main4();
            uc5_CalculateWagesFor20DayslnMonth.Main5();
            uc6_CalculateWageTill100HrsOr20IsReached.Main6();
            //uc7_ComputeEmpWageUsingClassMethod.Main7();
            //uc8_ComputeEmpWageForMultipleCompanies.Main8("reliance",25,2,10);

            // #region uc9
            //EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            //EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            //dMart.computeEmpWage();
            //Console.WriteLine(dMart.toString());
            //reliance.computeEmpWage();
            //Console.WriteLine(reliance.toString());
            //  #endregion uc9

            //#region UC10
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            //empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            //empWageBuilder.computeEmpWage();
            //#endregion


            //#region FinalSolution
            //EmpWageBuilder empWageBuild = new EmpWageBuilder();
            //empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
            //empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
            //empWageBuild.computeEmpWage();
            //#endregion

            Console.ReadLine();
        }
    }
}

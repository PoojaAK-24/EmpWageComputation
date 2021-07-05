using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
            {
            //UC1_PresentOrAbsent.empCheck();
            //UC2_Dailywage.DailyEmployeeWage();
            //UC3_PartTimeEmpWage.PartTimeEmp();
            //UC4_PartTimeUsingSwitch.PartTimeEmployeeWage();
            //UC5_CalWagesForMonth.EmployeeWageMonth();
            //UC6_NumberOfWorkingDays.NumberOFWorking();
            //UC7_UsingClassMethods.computeEmpWage();
            //UC8_MultipleCompanies.computeEmpWage("DMart", 20, 2, 10);
            //UC8_MultipleCompanies.computeEmpWage("Reliance", 20, 4, 20);
            
            //#region UC_9_Implementation
            //EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            //EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            //dMart.computeEmpWage();
            //Console.WriteLine(dMart.toString());
            //reliance.computeEmpWage();
            //Console.WriteLine(reliance.toString());
            //#endregion

            #region Uc_10
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            #endregion

            Console.ReadKey();
            }

        }
    }



using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class UC1_PresentOrAbsent
    {
        public static void empCheck()
        {
            int IS_FULL_Time = 1;
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == IS_FULL_Time)
                Console.WriteLine("Emp is present");
            else
                Console.WriteLine("Emp is absent");
        }
    }
}
   

using System;

namespace CSharp_Week3_Test.UseCase1_Payroll_Salary_Processing
{
    /// <summary>
    /// HR notification handler
    /// </summary>
    public static class HRNotification
    {
        public static void Notify(PaySlip slip)
        {
            Console.WriteLine(
                $"[HR] Salary processed for {slip.EmployeeName} ({slip.EmployeeType})");
        }
    }
}


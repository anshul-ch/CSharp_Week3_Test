using System;

namespace CSharp_Week3_Test.UseCase1_Payroll_Salary_Processing
{
    /// <summary>
    /// Finance notification handler
    /// </summary>
    public static class FinanceNotification
    {
        public static void Notify(PaySlip slip)
        {
            Console.WriteLine(
                $"[Finance] Net Pay {slip.Net} credited for Employee ID {slip.EmployeeId}");
        }
    }
}


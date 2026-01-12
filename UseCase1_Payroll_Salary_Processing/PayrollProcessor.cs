using System.Collections.Generic;
using System;

namespace CSharp_Week3_Test.UseCase1_Payroll_Salary_Processing
{
    /// <summary>
    /// Service class responsible for payroll processing
    /// </summary>
    public class PayrollProcessor
    {
        // Multicast delegate
        public SalaryProcessedHandler SalaryProcessed;

        public List<PaySlip> ProcessPayroll(List<Employee> employees)
        {
            List<PaySlip> paySlips = new List<PaySlip>();

            foreach (Employee emp in employees)
            {
                // Polymorphism in action
                PaySlip slip = emp.CalculatePay();
                paySlips.Add(slip);

                SalaryProcessed?.Invoke(slip);

                Console.WriteLine(
                    $"Processed: {slip.EmployeeName} | Gross: {slip.Gross} | Net: {slip.Net}");
            }

            return paySlips;
        }
    }
}


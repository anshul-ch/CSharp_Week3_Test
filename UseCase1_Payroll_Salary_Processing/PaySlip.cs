using System;

namespace CSharp_Week3_Test.UseCase1_Payroll_Salary_Processing
{
    /// <summary>
    /// Stores payroll calculation results
    /// </summary>
    public class PaySlip
    {
        public int EmployeeId { get; }
        public string EmployeeName { get; }
        public string EmployeeType { get; }
        public decimal Gross { get; }
        public decimal Deductions { get; }
        public decimal Net { get; }

        public PaySlip(int id, string name, string type, decimal gross, decimal deductions, decimal net)
        {
            EmployeeId = id;
            EmployeeName = name;
            EmployeeType = type;
            Gross = gross;
            Deductions = deductions;
            Net = net;
        }
    }
}


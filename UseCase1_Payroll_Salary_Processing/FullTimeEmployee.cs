using System;

namespace CSharp_Week3_Test.UseCase1_Payroll_Salary_Processing
{
    /// <summary>
    /// Represents a Full-Time employee
    /// </summary>
    public class FullTimeEmployee : Employee
    {
        private decimal _monthlySalary;

        public FullTimeEmployee(int id, string name, decimal monthlySalary)
            : base(id, name, "FullTime")
        {
            if (monthlySalary < 0)
                throw new ArgumentException("Salary cannot be negative");

            _monthlySalary = monthlySalary;
        }

        // Fixed salary with 20% deduction
        public override PaySlip CalculatePay()
        {
            decimal gross = _monthlySalary;
            decimal deductions = gross * 0.20m;
            decimal net = gross - deductions;

            return new PaySlip(Id, Name, EmployeeType, gross, deductions, net);
        }
    }
}


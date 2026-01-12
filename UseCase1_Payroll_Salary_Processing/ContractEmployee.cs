using System;

namespace CSharp_Week3_Test.UseCase1_Payroll_Salary_Processing
{
    /// <summary>
    /// Represents a Contract employee
    /// </summary>
    public class ContractEmployee : Employee
    {
        private decimal _dailyRate;
        private int _workingDays;

        public ContractEmployee(int id, string name, decimal dailyRate, int workingDays)
            : base(id, name, "Contract")
        {
            if (dailyRate < 0)
                throw new ArgumentException("Daily rate cannot be negative");

            if (workingDays < 0 || workingDays > 31)
                throw new ArgumentException("Working days must be between 0 and 31");

            _dailyRate = dailyRate;
            _workingDays = workingDays;
        }

        /// <summary>
        /// Contract pay calculation
        /// </summary>
        public override PaySlip CalculatePay()
        {
            decimal gross = _dailyRate * _workingDays;
            decimal deductions = gross * 0.10m;
            decimal net = gross - deductions;

            return new PaySlip(Id, Name, EmployeeType, gross, deductions, net);
        }
    }
}


using System;

namespace CSharp_Week3_Test.UseCase1_Payroll_Salary_Processing
{
    /// <summary>
    /// Abstract base class representing a generic employee
    /// </summary>
    public abstract class Employee
    {
        // Encapsulated fields
        private int ID;
        private string EmpName;
        private string EmpType;

        public int Id => ID;
        public string Name => EmpName;
        public string EmployeeType => EmpType;

        protected Employee(int id, string name, string employeeType)
        {
            if (id <= 0)
                throw new ArgumentException("Employee ID must be positive");

            ID = id;
            EmpName = name;
            EmpType = employeeType;
        }

        /// <summary>
        /// Polymorphic salary calculation
        /// </summary>
        public abstract PaySlip CalculatePay();
    }
}


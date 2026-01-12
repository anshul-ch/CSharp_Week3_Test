using System;

namespace CSharp_Week3_Test.UseCase1_Payroll_Salary_Processing
{
    /// <summary>
    /// Abstract base class representing a generic employee
    /// </summary>
    public abstract class Employee
    {
        // Encapsulated fields
        private int _id;
        private string _name;
        private string _employeeType;

        public int Id => _id;
        public string Name => _name;
        public string EmployeeType => _employeeType;

        protected Employee(int id, string name, string employeeType)
        {
            if (id <= 0)
                throw new ArgumentException("Employee ID must be positive");

            _id = id;
            _name = name;
            _employeeType = employeeType;
        }

        /// <summary>
        /// Polymorphic salary calculation
        /// </summary>
        public abstract PaySlip CalculatePay();
    }
}


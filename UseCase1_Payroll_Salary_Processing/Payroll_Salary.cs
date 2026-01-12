using System;
using System.Collections.Generic;
using System.Linq; // ✅ REQUIRED for Sum, Count, OrderByDescending

namespace CSharp_Week3_Test.UseCase1_Payroll_Salary_Processing
{
    class Payroll_Salary
    {
        static void Main(string[] args)
        {
            // Hardcoded sample data as allowed by assignment
            List<Employee> employees = new List<Employee>
            {
                new FullTimeEmployee(1, "Alice", 50000),
                new FullTimeEmployee(2, "Bob", 60000),
                new ContractEmployee(3, "Charlie", 1500, 20),
                new ContractEmployee(4, "Diana", 1200, 22),
                new FullTimeEmployee(5, "Evan", 45000),
                new ContractEmployee(6, "Fiona", 1000, 25)
            };

            Console.WriteLine("6 employees added successfully.\n");

            PayrollProcessor processor = new PayrollProcessor();

            // Multicast delegate subscriptions
            processor.SalaryProcessed += HRNotification.Notify;
            processor.SalaryProcessed += FinanceNotification.Notify;

            Console.WriteLine("Starting Payroll Processing...\n");

            List<PaySlip> results = processor.ProcessPayroll(employees);

            // Payroll Summary
            Console.WriteLine("\n===== PAYROLL SUMMARY =====");
            Console.WriteLine($"Total Employees: {results.Count}");
            Console.WriteLine($"Total Payout: {results.Sum(p => p.Net)}");
            Console.WriteLine($"Full-Time Count: {results.Count(p => p.EmployeeType == "FullTime")}");
            Console.WriteLine($"Contract Count: {results.Count(p => p.EmployeeType == "Contract")}");

            PaySlip highest = results.OrderByDescending(p => p.Net).First();
            Console.WriteLine($"Highest Net Salary: {highest.EmployeeName} - {highest.Net}");

            Console.WriteLine("\nPayroll processing completed successfully.");
        }
    }
}


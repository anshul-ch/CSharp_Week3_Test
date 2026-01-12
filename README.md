
# OOPS, Generic Collections & Delegates – Console Applications

This repository contains two C# console-based applications designed to demonstrate core object-oriented programming concepts, the use of generic collections, and delegate-based notifications through practical, real-world scenarios.

## Use Case 1: Payroll & Salary Processing

This simulates a payroll system where different types of employees are processed using inheritance and polymorphism. Salary calculations are performed, and multiple departments are notified after salary processing using delegates.

Main File:
**Payroll_Salary.cs** 

This file serves as the entry point of the payroll application and coordinates employee creation, payroll processing, notifications, and summary reporting.

### Project Structure
* UseCase1_Payroll_Salary_Processing
* Employee.cs                  – Abstract base class for all employees
* FullTimeEmployee.cs          – Salary calculation logic for full-time employees
* ContractEmployee.cs          – Salary calculation logic for contract employees
* PaySlip.cs                   – Stores payroll calculation details such as gross, deductions, and net pay
* SalaryProcessedHandler.cs    – Delegate definition for salary processed notifications
* PayrollProcessor.cs          – Processes payroll for all employees
* HRNotification.cs            – Handles HR-related notifications
* FinanceNotification.cs       – Handles Finance-related notifications
* Payroll_Salary.cs            – Main file that executes the payroll processing workflow

## Use Case 2: Online Order Processing & Status Notifications

This application represents an online order processing system where orders move through predefined lifecycle states. Each status change is validated against business rules, recorded in a history log, and communicated to multiple subscribers using delegates.

Main File:
**OnlineOrder_Processing.cs**

This file acts as the entry point of the order processing application and manages order creation, status transitions, notifications, and reporting.

Project Structure
* UseCase2_Online_Order_Processing
* Product.cs                   – Represents products available for ordering
* Customer.cs                  – Represents customers placing orders
* OrderItem.cs                 – Represents individual items within an order (composition)
* OrderStatus.cs               – Defines the order lifecycle states using an enum
* OrderStatusLog.cs            – Records the history of order status changes
* Order.cs                     – Represents an order containing items, current status, and history
* OrderService.cs              – Handles order operations and validates status transitions
* OrderStatusChangedHandler.cs – Delegate definition for order status change notifications
* CustomerNotification.cs      – Sends notifications to customers on status updates
* LogisticsNotification.cs     – Sends notifications to logistics on shipment events
* OnlineOrder_Processing.cs    – Main file that executes the order processing workflow

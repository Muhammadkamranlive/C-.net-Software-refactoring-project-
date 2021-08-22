using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class ClassEmployee
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePassword { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public double BasicSalary { get; set; }
        public int Scale { get; set; }
        public double Rent { get; set; }
        public double conveinceAllowance { get; set; }
        public double stationaryAllowance { get; set; }
        public int benevolentFund { get; set; }
        public double incomeTax { get; set; }
        public DateTime SalaryMonth { get; set; }
        public double takeHomeSalary { get; set; }

        // defualt  constructor
        public ClassEmployee()
        {

        }


       // parameterized constructor
        public ClassEmployee(string EmployeeID, string EmployeeName, string EmployeePassword, string Designation, string Department, double BasicSalary, int Scale, double Rent, double conveinceAllowance, double stationaryAllowance, int benevolentFund, double incomeTax, DateTime SalaryMonth, double takeHomeSalary)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.EmployeePassword = EmployeePassword;
            this.Department = Department;
            this.Designation = Designation;
            this.BasicSalary = BasicSalary;
            this.Scale = Scale;
            this.Rent = Rent;
            this.benevolentFund = benevolentFund;
            this.conveinceAllowance = conveinceAllowance;
            this.stationaryAllowance = stationaryAllowance;
            this.takeHomeSalary = takeHomeSalary;
            this.incomeTax = incomeTax;
            this.SalaryMonth = SalaryMonth;
        }

        public double assignBasicSalary(int salaryScale)
        {
            double basicSalary = 0;
            //Assigning  Basic Salary With respect Pay Scale...
            if (salaryScale >= 1 && salaryScale <= 4)
            {
                basicSalary = 14000;
            }
            else if (salaryScale >= 5 && salaryScale <= 9)
            {
                basicSalary = 22000;
            }
            else if (salaryScale >= 10 && salaryScale <= 15)
            {
                basicSalary = 40000;
            }
            else if (salaryScale >= 16 && salaryScale <= 19)
            {
                basicSalary = 70000;
            }
            else if (salaryScale >= 21 && salaryScale <= 22)
            {
                basicSalary = 100000;
            }
            else
            {
                basicSalary = 0;
            }


            return basicSalary;
        }
        // calaculation of the benvolent fund on the bases of salary scale  and assigning it  to benevolentFund 
        public int assignBenovlentFund(int salaryScale)
        {
            int benevolentFund = 0;
            if (salaryScale >= 1 && salaryScale <= 10)
            {
                benevolentFund = 700;

            }
            else if (salaryScale >= 11 && salaryScale <= 22)
            {
                benevolentFund = 1500;

            }
            else
            {
                benevolentFund = 0;

            }
            return benevolentFund;
        }
        public double deductIncome(int salaryScale)
        {
            double incomeTax = 0;
            double totalSalary = 0;

            //Income tax Deduction with respect to Basic Salary Scale  and assigning it to incomeTax
            if (salaryScale >= 1 && salaryScale <= 10)
            {
                incomeTax = 0.07 * totalSalary;

            }
            else if (salaryScale >= 11 && salaryScale <= 22)
            {
                incomeTax = 0.13 * totalSalary;

            }
            else
            {
                incomeTax = 0;

            }
            return incomeTax;
        }
        //Conveince Allowance Calculation by 9% of basic salary
        public double conveinceAllowanceCalcuation(double basicSalary)
        {
            double conveinceAllowance = 0;
            conveinceAllowance = 0.09 * basicSalary;
            return conveinceAllowance;
        }
        //Stationary Allowance Calculation by 2% of basic salary
        public double stationaryAllowanceCalcuation(double basicSalary)
        {
            double stationaryAllowance = 0;
            stationaryAllowance = 0.02 * basicSalary;
            return stationaryAllowance;
        }
        //House Rent Calculation by 17% of basic salary
        public double houseRentCalcuation(double basicSalary)
        {
            double houseRent = 0.17 * basicSalary;

            return houseRent;
        }
        // constructor for the searching employee id 
        public ClassEmployee(string EmployeeID)
        {
            this.EmployeeID = EmployeeID;
        }
        // constructor for the  login having id and password
        public ClassEmployee(string employeePassword, string employeeId)
        {
            EmployeePassword = employeePassword;
            EmployeeID = employeeId;
        }

    }
}

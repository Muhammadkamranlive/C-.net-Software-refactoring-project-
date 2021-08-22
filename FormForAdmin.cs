using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class FormForAdmin : Form
    {
        public FormForAdmin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonForAddEmployee_Click(object sender, EventArgs e)
        {
            //Parsing the combobx value into integer and  storing in salaryScale
            int salaryScale = int.Parse(comboBoxForEmployeeBasicPayScale.Text);
            //Declaring the variables
            double basicSalary = 0;
            double totalSalary = 0;
            double takeHomeSalary = 0;
            double houseRent = 0;
            double conveinceAllowance = 0;
            double stationaryAllowance = 0;
            int beneVolentFund = 0;
            double incomeTax = 0;

            //Making the date Object  from Date class and  assinging the current date
            DateTime datetime = DateTime.Now;

            //Making the Employee  class object
            ClassEmployee objectEmployee = new ClassEmployee();

            //calling the  assingnBasicSalary Function of the  class  employee and storing the value inside basic salary by passing salaryScale
            basicSalary = objectEmployee.assignBasicSalary(salaryScale);

            //calling the  assingnBenvolentFund Function of the  class  employee and storing the assinging value to benvolentFund by passing salaryScale
            beneVolentFund = objectEmployee.assignBenovlentFund(salaryScale);

            //calling the  houseRent Function of the  class  employee and assinging value to houseRent by passing basicSalary
            houseRent = objectEmployee.houseRentCalcuation(basicSalary);

            //calling the  assingnBenvolentFund Function of the  class  employee and assigning vale to conveinceAllowance by passing basicSalary
            conveinceAllowance = objectEmployee.conveinceAllowanceCalcuation(basicSalary);

            //calling the  stationaryAllowance Function of the  class  employee and assigning vale to stationaryAllowance by passing basicSalary
            stationaryAllowance = objectEmployee.stationaryAllowanceCalcuation(basicSalary);


            // calaculating the total Salary and assigning it to totalSalary
            totalSalary = basicSalary + houseRent + conveinceAllowance + stationaryAllowance;
            totalSalary = totalSalary - beneVolentFund;

            // calling deductIncome function by passing the salaryScale and  storing the value  and assigin it to incomeTax 
            incomeTax = objectEmployee.deductIncome(salaryScale);

            //deducting the takeHome Salary from totalSalary minus incomeTax and assigning the value to takeHomeSalary
            takeHomeSalary = totalSalary - incomeTax;

            //Calling the  parameterized constructor by passing the values
            ClassEmployee employeeObject = new ClassEmployee(textBoxForEmployeeID.Text, textBoxForEmployeeName.Text, textBoxForEmployeeDefaultPassword.Text, textBoxForEmployeeDesignation.Text, textBoxForEmployeeDepartment.Text, basicSalary, salaryScale, houseRent, conveinceAllowance, stationaryAllowance, beneVolentFund, incomeTax, datetime, takeHomeSalary);
            //calling the Dbconnectivity class function AddEmployee function and passing the Employee class object having the  values stored in it.
            ClassDataBaseConnectivity.AddEmployee(employeeObject);
            // clearing the textBox for the  clearing the previous data
            textBoxForEmployeeID.Clear();
            textBoxForEmployeeName.Clear();
            textBoxForEmployeeDepartment.Clear();
            textBoxForEmployeeDesignation.Clear();
            textBoxForEmployeeDefaultPassword.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonForSignOut_Click(object sender, EventArgs e)
        {
            FormForLogin ObejctLogin = new FormForLogin();
            ObejctLogin.Show();
            this.Hide();
        }
    }
}

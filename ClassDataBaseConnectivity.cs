using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace EmployeeManagementSystem
{
    class ClassDataBaseConnectivity
    {
        public static SqlConnection ConnectDataBase()
        {
            string connectionString = @"Data Source=DESKTOP-ATV5PRG\SQLEXPRESS;Initial Catalog=EmployeRecord;Integrated Security=True;";
            SqlConnection connect = new SqlConnection(connectionString);

            try
            {
                connect.Open();
                //  MessageBox.Show("DB Connected!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error in Connection!");
            }
            return connect;
        }


        public static void AddEmployee(ClassEmployee e)
        {
            string qry = "Insert into tblEmploye values(@EmployeeID,@EmployeeName,@Designation, @Department,@BasicSalary,@Scale, @Rent, @conveinceAllowance, @stationaryAllowance, @benevolentFund,  @incomeTax, @SalaryMonth, @takeHomeSalary, @EmployeePassword)";
            SqlConnection conn = ConnectDataBase();
            SqlCommand cmd = new SqlCommand(qry, conn);

            cmd.Parameters.AddWithValue("@EmployeeID", e.EmployeeID);
            cmd.Parameters.AddWithValue("@EmployeeName", e.EmployeeName);
            cmd.Parameters.AddWithValue("@Designation", e.Designation);
            cmd.Parameters.AddWithValue("@Department", e.Department);
            cmd.Parameters.AddWithValue("@BasicSalary", e.BasicSalary);
            cmd.Parameters.AddWithValue("@Scale", e.Scale);
            cmd.Parameters.AddWithValue("@Rent", e.Rent);
            cmd.Parameters.AddWithValue("@conveinceAllowance", e.conveinceAllowance);
            cmd.Parameters.AddWithValue("@stationaryAllowance", e.stationaryAllowance);
            cmd.Parameters.AddWithValue("@benevolentFund", e.benevolentFund);
            cmd.Parameters.AddWithValue("@incomeTax", e.incomeTax);
            cmd.Parameters.AddWithValue("@SalaryMonth", e.SalaryMonth);
            cmd.Parameters.AddWithValue("@takeHomeSalary", e.takeHomeSalary);
            cmd.Parameters.AddWithValue("@EmployeePassword", e.EmployeePassword);








            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success Employee Details has been added Successfully");

            }
            catch
            {
                MessageBox.Show("Insertion Error!!! Employee ID Should be unique");
            }
        }



        public static DataSet ViewEmployee(string id)
        {
            string qry = "Select EmployeeName,takeHomeSalary from tblEmploye where EmployeeID like '%" + id + "'  and SalaryMonth>= DATEADD(M, -3, GETDATE())";
            SqlConnection conn = ConnectDataBase();
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(qry, conn);
            adp.Fill(ds, "tblEmploye");
            return ds;
        }

        public static SqlDataReader SearchID()
        {
            string qry = "select EmployeeID,EmployeePassword from tblEmploye";
            SqlConnection conn = ConnectDataBase();

            SqlCommand cmd = new SqlCommand(qry, conn);

            return cmd.ExecuteReader();

        }
        public static SqlDataReader Login()
        {
            string qry = "select EmployeeID,EmployeePassword,Designation from tblEmploye";
            SqlConnection conn = ConnectDataBase();
            SqlCommand cmd = new SqlCommand(qry, conn);

            return cmd.ExecuteReader();

        }

        public static void ResetPassword(ClassEmployee e)
        {
            string qry = "Update tblEmploye Set EmployeePassword=@pass where EmployeeID=@id";
            SqlConnection conn = ConnectDataBase();
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@pass", e.EmployeePassword);
            cmd.Parameters.AddWithValue("@id", e.EmployeeID);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Error!!!");
            }
        }

    }
}

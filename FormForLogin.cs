using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EmployeeManagementSystem
{
    public partial class FormForLogin : Form
    {
        public FormForLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonForLogin_Click(object sender, EventArgs e)
        {

            string Employid = textBoxForEmployeeID.Text;
            string password = textBoxForEmployeePassword.Text;
            string storeEmployeeID = "";
            string storeEmployeePassword = "";
            bool login = false;
            bool admin = false;
            bool user = false;
            string storeDesignation = "";
            string Designation = "admin";
            if (radioButtonForAdmin.Checked == true)
            {
                admin = true;
            }
            else
            {
                user = true;
            }
            SqlDataReader reader = ClassDataBaseConnectivity.Login();
            while (reader.Read())
            {
                storeEmployeeID = reader["EmployeeID"].ToString();
                storeEmployeePassword = reader["EmployeePassword"].ToString();
                storeDesignation = reader["Designation"].ToString();
                if (Employid == storeEmployeeID && password == storeEmployeePassword && admin == true && storeDesignation == Designation)
                {
                    MessageBox.Show("Login Successful");
                    FormForAdmin objectAdmin = new FormForAdmin();
                    objectAdmin.Show();
                    this.Hide();
                    login = true;
                    break;
                }
                else if (Employid == storeEmployeeID && password == storeEmployeePassword && user == true && storeDesignation != Designation)
                {
                    MessageBox.Show("Login Success");
                    FormForEmployee objectEmployee = new FormForEmployee();
                    objectEmployee.Show();
                    this.Hide();
                    login = true;
                    break;
                }
                else
                {
                    login = false;
                }




            }
            if (login == false)
            {
                MessageBox.Show("Please Check  your Employee ID OR Password");
            }
        }
    }
}

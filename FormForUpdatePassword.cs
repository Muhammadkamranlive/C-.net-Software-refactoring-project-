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
    public partial class FormForUpdatePassword : Form
    {
        public FormForUpdatePassword()
        {
            InitializeComponent();
        }

        private void buttonForUpdateEmployeePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = textBoxForOldPassword.Text;
            string newPassword = textBoxForNewPassword.Text;
            string storeEmployId;
            string storeOrignalPassword;
            string tempId = textBoxForEmployeeID.Text;
            bool find = false;

            SqlDataReader reader = ClassDataBaseConnectivity.SearchID();
            while (reader.Read())
            {
                storeEmployId = reader["EmployeeID"].ToString();
                storeOrignalPassword = reader["EmployeePassword"].ToString();
                if (storeEmployId == tempId && storeOrignalPassword == oldPassword)
                {
                    if (MessageBox.Show("Do you want to change password?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ClassEmployee employeeObject = new ClassEmployee(newPassword, storeEmployId);
                        ClassDataBaseConnectivity.ResetPassword(employeeObject);
                        find = true;
                        break;
                    }
                }



            }

            if (find == false)
            {
                MessageBox.Show("Invalid ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxForEmployeeID.Clear();
            textBoxForNewPassword.Clear();
            textBoxForOldPassword.Clear();
        }

        private void buttonForViewLastThreeMonthRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application Is Valid only For One Month");
        }

        private void buttonForSignOut_Click(object sender, EventArgs e)
        {
            FormForLogin objectLogin = new FormForLogin();
            objectLogin.Show();
            this.Hide();
        }

        private void buttonForViewRecord_Click(object sender, EventArgs e)
        {
            FormForEmployee objectforemployee = new FormForEmployee();
            objectforemployee.Show();
            this.Hide();
        }
    }
}

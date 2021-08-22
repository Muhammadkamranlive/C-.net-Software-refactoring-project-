using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class FormForEmployee : Form
    {
        public FormForEmployee()
        {
            InitializeComponent();
        }

        private void buttonForSearchEmployeeRecord_Click(object sender, EventArgs e)
        {
            string storeEmployeeId;
            string userEnteredEmployeeId = textBoxForEmployeeID.Text;

            SqlDataReader reader = ClassDataBaseConnectivity.SearchID();
            while (reader.Read())
            {
                storeEmployeeId = reader["EmployeeID"].ToString();
                if (storeEmployeeId == userEnteredEmployeeId)
                {
                    DataSet ds = ClassDataBaseConnectivity.ViewEmployee(textBoxForEmployeeID.Text);
                    EmployeeGridView.DataSource = ds.Tables["tblEmploye"];
                    textBoxForEmployeeID.Clear();
                    break;
                }



            }
        }

        private void buttonForUpdatePassword_Click(object sender, EventArgs e)
        {
            FormForUpdatePassword obejctUpdatePassword = new FormForUpdatePassword();
            obejctUpdatePassword.Show();
            this.Hide();
        }

        private void buttonForSignOut_Click(object sender, EventArgs e)
        {

        }

        private void buttonForViewRecord_Click(object sender, EventArgs e)
        {

        }

        private void buttonForViewLastThreeMonthRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application Is Valid only For One Month");
        }

        private void buttonForSignOut_Click_1(object sender, EventArgs e)
        {
            FormForLogin objectLogin = new FormForLogin();
            objectLogin.Show();
            this.Hide();
        }
    }
}

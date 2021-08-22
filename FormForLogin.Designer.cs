
namespace EmployeeManagementSystem
{
    partial class FormForLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxForEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxForEmployeePassword = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.radioButtonForUser = new System.Windows.Forms.RadioButton();
            this.radioButtonForAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonForLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonForLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonForAdmin);
            this.panel1.Controls.Add(this.radioButtonForUser);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.textBoxForEmployeePassword);
            this.panel1.Controls.Add(this.textBoxForEmployeeID);
            this.panel1.Location = new System.Drawing.Point(164, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 454);
            this.panel1.TabIndex = 0;
            // 
            // textBoxForEmployeeID
            // 
            this.textBoxForEmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxForEmployeeID.Location = new System.Drawing.Point(61, 161);
            this.textBoxForEmployeeID.Multiline = true;
            this.textBoxForEmployeeID.Name = "textBoxForEmployeeID";
            this.textBoxForEmployeeID.Size = new System.Drawing.Size(376, 44);
            this.textBoxForEmployeeID.TabIndex = 0;
            this.textBoxForEmployeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxForEmployeePassword
            // 
            this.textBoxForEmployeePassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxForEmployeePassword.Location = new System.Drawing.Point(61, 251);
            this.textBoxForEmployeePassword.Multiline = true;
            this.textBoxForEmployeePassword.Name = "textBoxForEmployeePassword";
            this.textBoxForEmployeePassword.PasswordChar = '*';
            this.textBoxForEmployeePassword.Size = new System.Drawing.Size(376, 44);
            this.textBoxForEmployeePassword.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(67, 131);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(67, 13);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "Employee ID";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(58, 222);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(102, 13);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Employee Password";
            // 
            // radioButtonForUser
            // 
            this.radioButtonForUser.AutoSize = true;
            this.radioButtonForUser.Checked = true;
            this.radioButtonForUser.Location = new System.Drawing.Point(96, 64);
            this.radioButtonForUser.Name = "radioButtonForUser";
            this.radioButtonForUser.Size = new System.Drawing.Size(47, 17);
            this.radioButtonForUser.TabIndex = 11;
            this.radioButtonForUser.Text = "User";
            this.radioButtonForUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonForAdmin
            // 
            this.radioButtonForAdmin.AutoSize = true;
            this.radioButtonForAdmin.Location = new System.Drawing.Point(306, 64);
            this.radioButtonForAdmin.Name = "radioButtonForAdmin";
            this.radioButtonForAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonForAdmin.TabIndex = 12;
            this.radioButtonForAdmin.Text = "Admin";
            this.radioButtonForAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sign In";
            // 
            // buttonForLogin
            // 
            this.buttonForLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.buttonForLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForLogin.Location = new System.Drawing.Point(61, 334);
            this.buttonForLogin.Name = "buttonForLogin";
            this.buttonForLogin.Size = new System.Drawing.Size(376, 57);
            this.buttonForLogin.TabIndex = 14;
            this.buttonForLogin.Text = "login";
            this.buttonForLogin.UseVisualStyleBackColor = false;
            this.buttonForLogin.Click += new System.EventHandler(this.buttonForLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(866, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxForEmployeeID;
        private System.Windows.Forms.TextBox textBoxForEmployeePassword;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.RadioButton radioButtonForUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.RadioButton radioButtonForAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonForLogin;
    }
}
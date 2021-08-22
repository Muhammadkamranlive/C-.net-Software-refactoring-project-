
namespace EmployeeManagementSystem
{
    partial class FormForAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxForEmployeeID = new System.Windows.Forms.TextBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.lbiD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxForEmployeeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxForEmployeeDepartment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxForEmployeeDesignation = new System.Windows.Forms.TextBox();
            this.comboBoxForEmployeeBasicPayScale = new System.Windows.Forms.ComboBox();
            this.textBoxForEmployeeDefaultPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonForAddEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonForSignOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonForSignOut);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 663);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 146);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxForEmployeeID
            // 
            this.textBoxForEmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxForEmployeeID.Location = new System.Drawing.Point(248, 224);
            this.textBoxForEmployeeID.Multiline = true;
            this.textBoxForEmployeeID.Name = "textBoxForEmployeeID";
            this.textBoxForEmployeeID.Size = new System.Drawing.Size(290, 44);
            this.textBoxForEmployeeID.TabIndex = 2;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(391, 165);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(243, 25);
            this.lbHeader.TabIndex = 19;
            this.lbHeader.Text = "Add Employee Details";
            // 
            // lbiD
            // 
            this.lbiD.AutoSize = true;
            this.lbiD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbiD.Location = new System.Drawing.Point(254, 201);
            this.lbiD.Name = "lbiD";
            this.lbiD.Size = new System.Drawing.Size(100, 20);
            this.lbiD.TabIndex = 20;
            this.lbiD.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Employee Name";
            // 
            // textBoxForEmployeeName
            // 
            this.textBoxForEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxForEmployeeName.Location = new System.Drawing.Point(568, 224);
            this.textBoxForEmployeeName.Multiline = true;
            this.textBoxForEmployeeName.Name = "textBoxForEmployeeName";
            this.textBoxForEmployeeName.Size = new System.Drawing.Size(372, 44);
            this.textBoxForEmployeeName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Employee Department";
            // 
            // textBoxForEmployeeDepartment
            // 
            this.textBoxForEmployeeDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxForEmployeeDepartment.Location = new System.Drawing.Point(248, 331);
            this.textBoxForEmployeeDepartment.Multiline = true;
            this.textBoxForEmployeeDepartment.Name = "textBoxForEmployeeDepartment";
            this.textBoxForEmployeeDepartment.Size = new System.Drawing.Size(692, 44);
            this.textBoxForEmployeeDepartment.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Employee Designation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Select Basic Pay Scale";
            // 
            // textBoxForEmployeeDesignation
            // 
            this.textBoxForEmployeeDesignation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxForEmployeeDesignation.Location = new System.Drawing.Point(248, 411);
            this.textBoxForEmployeeDesignation.Multiline = true;
            this.textBoxForEmployeeDesignation.Name = "textBoxForEmployeeDesignation";
            this.textBoxForEmployeeDesignation.Size = new System.Drawing.Size(280, 44);
            this.textBoxForEmployeeDesignation.TabIndex = 27;
            // 
            // comboBoxForEmployeeBasicPayScale
            // 
            this.comboBoxForEmployeeBasicPayScale.FormattingEnabled = true;
            this.comboBoxForEmployeeBasicPayScale.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "21",
            "22"});
            this.comboBoxForEmployeeBasicPayScale.Location = new System.Drawing.Point(558, 425);
            this.comboBoxForEmployeeBasicPayScale.Name = "comboBoxForEmployeeBasicPayScale";
            this.comboBoxForEmployeeBasicPayScale.Size = new System.Drawing.Size(362, 21);
            this.comboBoxForEmployeeBasicPayScale.TabIndex = 30;
            // 
            // textBoxForEmployeeDefaultPassword
            // 
            this.textBoxForEmployeeDefaultPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxForEmployeeDefaultPassword.Location = new System.Drawing.Point(248, 490);
            this.textBoxForEmployeeDefaultPassword.Multiline = true;
            this.textBoxForEmployeeDefaultPassword.Name = "textBoxForEmployeeDefaultPassword";
            this.textBoxForEmployeeDefaultPassword.Size = new System.Drawing.Size(692, 44);
            this.textBoxForEmployeeDefaultPassword.TabIndex = 31;
            this.textBoxForEmployeeDefaultPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Defualt Password";
            // 
            // buttonForAddEmployee
            // 
            this.buttonForAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.buttonForAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForAddEmployee.Location = new System.Drawing.Point(359, 556);
            this.buttonForAddEmployee.Name = "buttonForAddEmployee";
            this.buttonForAddEmployee.Size = new System.Drawing.Size(376, 57);
            this.buttonForAddEmployee.TabIndex = 33;
            this.buttonForAddEmployee.Text = "Add Employee Details";
            this.buttonForAddEmployee.UseVisualStyleBackColor = false;
            this.buttonForAddEmployee.Click += new System.EventHandler(this.buttonForAddEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(189, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 36;
            this.label2.Text = "Admin Area";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(189, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Employee Management System ";
            // 
            // buttonForSignOut
            // 
            this.buttonForSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.buttonForSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForSignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForSignOut.Location = new System.Drawing.Point(0, 164);
            this.buttonForSignOut.Name = "buttonForSignOut";
            this.buttonForSignOut.Size = new System.Drawing.Size(214, 57);
            this.buttonForSignOut.TabIndex = 34;
            this.buttonForSignOut.Text = "SignOut";
            this.buttonForSignOut.UseVisualStyleBackColor = false;
            this.buttonForSignOut.Click += new System.EventHandler(this.buttonForSignOut_Click);
            // 
            // FormForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(956, 663);
            this.Controls.Add(this.buttonForAddEmployee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxForEmployeeDefaultPassword);
            this.Controls.Add(this.comboBoxForEmployeeBasicPayScale);
            this.Controls.Add(this.textBoxForEmployeeDesignation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxForEmployeeDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxForEmployeeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbiD);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.textBoxForEmployeeID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormForAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForAdmin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxForEmployeeID;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbiD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxForEmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxForEmployeeDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxForEmployeeDesignation;
        private System.Windows.Forms.ComboBox comboBoxForEmployeeBasicPayScale;
        private System.Windows.Forms.TextBox textBoxForEmployeeDefaultPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonForAddEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonForSignOut;
    }
}
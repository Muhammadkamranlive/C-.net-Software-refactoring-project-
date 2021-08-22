
namespace EmployeeManagementSystem
{
    partial class FormForEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbEmployeeSection = new System.Windows.Forms.Label();
            this.lbEmployeeId = new System.Windows.Forms.Label();
            this.textBoxForEmployeeID = new System.Windows.Forms.TextBox();
            this.buttonForSearchEmployeeRecord = new System.Windows.Forms.Button();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.buttonForUpdatePassword = new System.Windows.Forms.Button();
            this.buttonForViewLastThreeMonthRecord = new System.Windows.Forms.Button();
            this.buttonForViewRecord = new System.Windows.Forms.Button();
            this.buttonForSignOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonForViewLastThreeMonthRecord);
            this.panel1.Controls.Add(this.buttonForViewRecord);
            this.panel1.Controls.Add(this.buttonForSignOut);
            this.panel1.Controls.Add(this.buttonForUpdatePassword);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 604);
            this.panel1.TabIndex = 1;
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
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbEmployeeSection);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 169);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(136, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbEmployeeSection
            // 
            this.lbEmployeeSection.AutoSize = true;
            this.lbEmployeeSection.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeSection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmployeeSection.Location = new System.Drawing.Point(242, 37);
            this.lbEmployeeSection.Name = "lbEmployeeSection";
            this.lbEmployeeSection.Size = new System.Drawing.Size(230, 40);
            this.lbEmployeeSection.TabIndex = 2;
            this.lbEmployeeSection.Text = "Employee Area";
            // 
            // lbEmployeeId
            // 
            this.lbEmployeeId.AutoSize = true;
            this.lbEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeId.Location = new System.Drawing.Point(268, 196);
            this.lbEmployeeId.Name = "lbEmployeeId";
            this.lbEmployeeId.Size = new System.Drawing.Size(182, 20);
            this.lbEmployeeId.TabIndex = 35;
            this.lbEmployeeId.Text = "Enter Your Employee Id ";
            this.lbEmployeeId.UseMnemonic = false;
            // 
            // textBoxForEmployeeID
            // 
            this.textBoxForEmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxForEmployeeID.Location = new System.Drawing.Point(272, 240);
            this.textBoxForEmployeeID.Multiline = true;
            this.textBoxForEmployeeID.Name = "textBoxForEmployeeID";
            this.textBoxForEmployeeID.Size = new System.Drawing.Size(290, 44);
            this.textBoxForEmployeeID.TabIndex = 36;
            // 
            // buttonForSearchEmployeeRecord
            // 
            this.buttonForSearchEmployeeRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.buttonForSearchEmployeeRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForSearchEmployeeRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForSearchEmployeeRecord.Location = new System.Drawing.Point(642, 232);
            this.buttonForSearchEmployeeRecord.Name = "buttonForSearchEmployeeRecord";
            this.buttonForSearchEmployeeRecord.Size = new System.Drawing.Size(214, 52);
            this.buttonForSearchEmployeeRecord.TabIndex = 37;
            this.buttonForSearchEmployeeRecord.Text = "View Record";
            this.buttonForSearchEmployeeRecord.UseVisualStyleBackColor = false;
            this.buttonForSearchEmployeeRecord.Click += new System.EventHandler(this.buttonForSearchEmployeeRecord_Click);
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmployeeGridView.GridColor = System.Drawing.Color.Blue;
            this.EmployeeGridView.Location = new System.Drawing.Point(214, 326);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.Size = new System.Drawing.Size(726, 278);
            this.EmployeeGridView.TabIndex = 38;
            // 
            // buttonForUpdatePassword
            // 
            this.buttonForUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.buttonForUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForUpdatePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForUpdatePassword.Location = new System.Drawing.Point(0, 249);
            this.buttonForUpdatePassword.Name = "buttonForUpdatePassword";
            this.buttonForUpdatePassword.Size = new System.Drawing.Size(214, 77);
            this.buttonForUpdatePassword.TabIndex = 35;
            this.buttonForUpdatePassword.Text = "Update Password";
            this.buttonForUpdatePassword.UseVisualStyleBackColor = false;
            this.buttonForUpdatePassword.Click += new System.EventHandler(this.buttonForUpdatePassword_Click);
            // 
            // buttonForViewLastThreeMonthRecord
            // 
            this.buttonForViewLastThreeMonthRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.buttonForViewLastThreeMonthRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForViewLastThreeMonthRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForViewLastThreeMonthRecord.Location = new System.Drawing.Point(0, 332);
            this.buttonForViewLastThreeMonthRecord.Name = "buttonForViewLastThreeMonthRecord";
            this.buttonForViewLastThreeMonthRecord.Size = new System.Drawing.Size(214, 76);
            this.buttonForViewLastThreeMonthRecord.TabIndex = 40;
            this.buttonForViewLastThreeMonthRecord.Text = "View Last Three Month Record";
            this.buttonForViewLastThreeMonthRecord.UseVisualStyleBackColor = false;
            this.buttonForViewLastThreeMonthRecord.Click += new System.EventHandler(this.buttonForViewLastThreeMonthRecord_Click);
            // 
            // buttonForViewRecord
            // 
            this.buttonForViewRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.buttonForViewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForViewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForViewRecord.Location = new System.Drawing.Point(0, 167);
            this.buttonForViewRecord.Name = "buttonForViewRecord";
            this.buttonForViewRecord.Size = new System.Drawing.Size(214, 76);
            this.buttonForViewRecord.TabIndex = 39;
            this.buttonForViewRecord.Text = "View Record";
            this.buttonForViewRecord.UseVisualStyleBackColor = false;
            this.buttonForViewRecord.Click += new System.EventHandler(this.buttonForViewRecord_Click);
            // 
            // buttonForSignOut
            // 
            this.buttonForSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(156)))), ((int)(((byte)(221)))));
            this.buttonForSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForSignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForSignOut.Location = new System.Drawing.Point(0, 414);
            this.buttonForSignOut.Name = "buttonForSignOut";
            this.buttonForSignOut.Size = new System.Drawing.Size(214, 76);
            this.buttonForSignOut.TabIndex = 38;
            this.buttonForSignOut.Text = "SignOut";
            this.buttonForSignOut.UseVisualStyleBackColor = false;
            this.buttonForSignOut.Click += new System.EventHandler(this.buttonForSignOut_Click_1);
            // 
            // FormForEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(940, 604);
            this.Controls.Add(this.EmployeeGridView);
            this.Controls.Add(this.buttonForSearchEmployeeRecord);
            this.Controls.Add(this.textBoxForEmployeeID);
            this.Controls.Add(this.lbEmployeeId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormForEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForEmployee";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbEmployeeSection;
        private System.Windows.Forms.Label lbEmployeeId;
        private System.Windows.Forms.TextBox textBoxForEmployeeID;
        private System.Windows.Forms.Button buttonForSearchEmployeeRecord;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.Button buttonForUpdatePassword;
        private System.Windows.Forms.Button buttonForViewLastThreeMonthRecord;
        private System.Windows.Forms.Button buttonForViewRecord;
        private System.Windows.Forms.Button buttonForSignOut;
    }
}
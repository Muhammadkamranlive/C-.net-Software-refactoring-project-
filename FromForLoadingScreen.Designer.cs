
namespace EmployeeManagementSystem
{
    partial class FormLoading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
            this.pictureBoxForLoadingLogo = new System.Windows.Forms.PictureBox();
            this.panelLoader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerForLoading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForLoadingLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxForLoadingLogo
            // 
            this.pictureBoxForLoadingLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForLoadingLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxForLoadingLogo.Image")));
            this.pictureBoxForLoadingLogo.Location = new System.Drawing.Point(232, 37);
            this.pictureBoxForLoadingLogo.Name = "pictureBoxForLoadingLogo";
            this.pictureBoxForLoadingLogo.Size = new System.Drawing.Size(143, 126);
            this.pictureBoxForLoadingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxForLoadingLogo.TabIndex = 4;
            this.pictureBoxForLoadingLogo.TabStop = false;
            // 
            // panelLoader
            // 
            this.panelLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.panelLoader.Location = new System.Drawing.Point(-1, 312);
            this.panelLoader.Name = "panelLoader";
            this.panelLoader.Size = new System.Drawing.Size(80, 21);
            this.panelLoader.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(105, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Management System";
            // 
            // timerForLoading
            // 
            this.timerForLoading.Enabled = true;
            this.timerForLoading.Interval = 80;
            this.timerForLoading.Tick += new System.EventHandler(this.timerForLoading_Tick);
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLoader);
            this.Controls.Add(this.pictureBoxForLoadingLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoading";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.Load += new System.EventHandler(this.FormLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForLoadingLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxForLoadingLogo;
        private System.Windows.Forms.Panel panelLoader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerForLoading;
    }
}


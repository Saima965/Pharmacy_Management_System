namespace Project
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrderMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_C_Order1 = new Project.CustomerUC.UC_C_Order();
            this.uC_C_ViewMedicine1 = new Project.CustomerUC.UC_C_ViewMedicine();
            this.uC_C_Profile1 = new Project.CustomerUC.UC_C_Profile();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnOrderMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1542, 168);
            this.panel1.TabIndex = 19;
            // 
            // btnProfile
            // 
            this.btnProfile.BorderColor = System.Drawing.Color.Purple;
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProfile.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProfile.Location = new System.Drawing.Point(364, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(180, 166);
            this.btnProfile.TabIndex = 13;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Purple;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::Project.Properties.Resources.logout;
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(1277, 0);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(180, 168);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOrderMedicine
            // 
            this.btnOrderMedicine.BackColor = System.Drawing.Color.Purple;
            this.btnOrderMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrderMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnOrderMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnOrderMedicine.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnOrderMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMedicine.ForeColor = System.Drawing.Color.White;
            this.btnOrderMedicine.Image = global::Project.Properties.Resources.order;
            this.btnOrderMedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnOrderMedicine.Location = new System.Drawing.Point(979, 0);
            this.btnOrderMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrderMedicine.Name = "btnOrderMedicine";
            this.btnOrderMedicine.Size = new System.Drawing.Size(180, 168);
            this.btnOrderMedicine.TabIndex = 11;
            this.btnOrderMedicine.Text = "Order Medicine";
            this.btnOrderMedicine.Click += new System.EventHandler(this.btnOrderMedicine_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.BackColor = System.Drawing.Color.Purple;
            this.btnViewMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnViewMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.Image = global::Project.Properties.Resources.view_64px;
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewMedicine.Location = new System.Drawing.Point(672, 0);
            this.btnViewMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(180, 168);
            this.btnViewMedicine.TabIndex = 8;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "      Customer     ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project.Properties.Resources.Customers;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(283, 161);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_C_Order1);
            this.panel2.Controls.Add(this.uC_C_ViewMedicine1);
            this.panel2.Controls.Add(this.uC_C_Profile1);
            this.panel2.Location = new System.Drawing.Point(-1, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1542, 880);
            this.panel2.TabIndex = 20;
            // 
            // uC_C_Order1
            // 
            this.uC_C_Order1.BackColor = System.Drawing.Color.White;
            this.uC_C_Order1.Location = new System.Drawing.Point(2, 1);
            this.uC_C_Order1.Name = "uC_C_Order1";
            this.uC_C_Order1.Size = new System.Drawing.Size(1542, 880);
            this.uC_C_Order1.TabIndex = 2;
            this.uC_C_Order1.Load += new System.EventHandler(this.uC_C_Order1_Load);
            // 
            // uC_C_ViewMedicine1
            // 
            this.uC_C_ViewMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_C_ViewMedicine1.Location = new System.Drawing.Point(1, 1);
            this.uC_C_ViewMedicine1.Name = "uC_C_ViewMedicine1";
            this.uC_C_ViewMedicine1.Size = new System.Drawing.Size(1542, 880);
            this.uC_C_ViewMedicine1.TabIndex = 1;
            // 
            // uC_C_Profile1
            // 
            this.uC_C_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_C_Profile1.Location = new System.Drawing.Point(2, 1);
            this.uC_C_Profile1.Name = "uC_C_Profile1";
            this.uC_C_Profile1.Size = new System.Drawing.Size(1542, 880);
            this.uC_C_Profile1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1438, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 47);
            this.btnExit.TabIndex = 59;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1541, 1100);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnOrderMedicine;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private CustomerUC.UC_C_Profile uC_C_Profile1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private CustomerUC.UC_C_ViewMedicine uC_C_ViewMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private CustomerUC.UC_C_Order uC_C_Order1;
    }
}
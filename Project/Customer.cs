using Project.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Customer : Form
    {
        String user = "";

        public Customer()
        {
            InitializeComponent();
            
        }

        public string ID
        {
            get { return user.ToString(); }
        }

      //  public object userCNameLabel { get; }

      

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_C_Profile1.Visible = true;
            uC_C_Profile1.BringToFront();
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customer_Load_1(object sender, EventArgs e)
        {
            uC_C_Profile1.Visible=false;
            uC_C_ViewMedicine1.Visible=false;
            uC_C_Order1.Visible=false;
            

        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_C_ViewMedicine1.Visible=true;
            uC_C_ViewMedicine1.BringToFront();
        }

        private void btnOrderMedicine_Click(object sender, EventArgs e)
        {
            uC_C_Order1.Visible=true;
            uC_C_Order1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
            this.Hide();
        }

        private void uC_C_Order1_Load(object sender, EventArgs e)
        {

        }
    }
}

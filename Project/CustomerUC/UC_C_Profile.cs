using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project.CustomerUC
{
    public partial class UC_C_Profile : UserControl
    {
        function fn = new function();
        String query;

        public UC_C_Profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { userCNameLabel.Text = value; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String username = userCNameLabel.Text;
            String pass = txtPassword.Text;

            query = "update users set userRole='" + role + "',name='" + name + "',dob='" + dob + "',mobile=" + mobile + ",email='" + email + "',pass='" + pass + "'where username='" + username + "'";
            fn.setData(query, "Profile Updation Successful.");
        }

        private void UC_C_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username= '" + userCNameLabel.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            { 
            txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();

        }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_C_Profile_Enter(this, null);
        }

        private void userCNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

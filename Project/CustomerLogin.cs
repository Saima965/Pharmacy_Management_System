using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Project
{
    public partial class CustomerLogin : Form
    {
        function fn = new function();
        String query;
        DataSet ds;

        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getData(query);

                query = "select * from users where username ='" + txtUsername.Text + "' and pass='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                String role = ds.Tables[0].Rows[0][1].ToString();
                if (role == "Customer")
                   {
                    Customer cust = new Customer();
                    cust.Show();
                    this.Hide();
                   }
               
                    //String role = ds.Tables[0].Rows[0][1].ToString();
                    /*if (role == "Administrator")
                    {
                        Adminstrator admin = new Adminstrator(txtUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                    else if (role == "Customer")
                    {
                        Customer cust = new Customer();
                        cust.Show();
                        this.Hide();
                    }*/
                }
                else
                {
                    MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            selection sl = new selection();
            sl.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            customerSignUp sl= new customerSignUp();
            sl.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }


using MobileFixVS2015.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileFixVS2015
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                try
                {
                    clsLogin user = new clsLogin();
                    user.UserName = txtUser.Text;
                    user.Password = txtPassword.Text;


                    clsDBLogin dbLogin = new clsDBLogin();
                    int Useradded = 0;
                    Useradded = dbLogin.AddUser(user);
                    if (Useradded > 0)
                    {
                        lblMessage.Text = "User has been added.";
                        txtUser.Clear();
                        txtPassword.Clear();
                        txtUser.Focus();
                    }
                    else
                    {
                        lblMessage.Text = "Error. Please try again.";
                        txtUser.Clear();
                        txtPassword.Clear();
                        txtUser.Focus();
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidated()
        {
            if (txtUser.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Clear();
                txtUser.Focus();
                return false;
            }

            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

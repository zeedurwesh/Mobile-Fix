using MobileFix;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CheckLoginDetails();
        }

        private void CheckLoginDetails()
        {
            clsLogin memberLogin = GetLoginDetails();
        }

        private clsLogin GetLoginDetails()
        {
            clsLogin lg = new clsLogin();
            clsDBLogin dbLogin = new clsDBLogin();



            return lg;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                try
                {
                    clsLogin user = new clsLogin();
                    user.UserName = txtName.Text;
                    user.Password = txtPassword.Text;


                    clsDBLogin dbLogin = new clsDBLogin();
                    dbLogin.CheckUser(user);
                    if (dbLogin.Count > 0)
                    {
                        this.Hide();
                        frmMenu ss = new frmMenu();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("User Name or Password is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Clear();
                        txtPassword.Clear();
                        txtName.Focus();
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
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                txtName.Focus();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHelper;

namespace NetCSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegister register = new UserRegister(this);
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                if (myData.LocateAccount(txtUsername.Text, txtPassword.Text))
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Account!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

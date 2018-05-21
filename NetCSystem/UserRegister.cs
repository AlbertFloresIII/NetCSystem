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
    public partial class UserRegister : Form
    {
        public UserRegister(Form parentForm)
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtNewUsername.Text == "" || txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill up the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password Do not match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                        if(!myData.AddUser(txtNewUsername.Text, txtNewPassword.Text)) //Parameters to pass to DataAccess class
                    {
                            MessageBox.Show("Registered!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login login = new Login();
                            login.Show();
                            this.Close();
                        }

                        else
                        {
                            if (MessageBox.Show("User ID already exist!", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                            {
                                txtNewUsername.Clear();
                                txtNewPassword.Clear();
                                txtConfirmPassword.Clear();
                            }
                        }
                }
            }
        }
    }
}

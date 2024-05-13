using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Laboratory
{
    public partial class LoginForm_2 : Form
    {
        public LoginForm_2()
        {
            InitializeComponent();
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';

            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            using (var db = new Medical_Laboratory_Entities())
            {
                var usern = db.User.FirstOrDefault(User => User.Email == txtUsername.Text && User.Password == txtPassword.Text);
                if (usern == null)
                {
                    MessageBox.Show("Неверно введен логин или пароль");
                }
                else
                {
                    new Main_Page().Show();
                    this.Hide();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}

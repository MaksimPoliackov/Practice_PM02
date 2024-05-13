using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Laboratory
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void checkboxShowPass_CheckedChanged_1(object sender, EventArgs e)
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

        private void registrationButton_Click_1(object sender, EventArgs e)
        {
            using (var db = new Medical_Laboratory_Entities())
            {
                var usern = db.User.FirstOrDefault(User => User.Login == txtUsername.Text && User.Password == txtPassword.Text);
                if (usern == null)
                {
                    MessageBox.Show("Неверно введен логин или пароль");
                }
                    else
                {
                    new Main_Page().Show();
                    this.Hide();
                    string s = txtUsername.Text;
                }
            }

        }

        private void clearButton_Click_1(object sender, EventArgs e)
        { 
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();

        }
    }
}

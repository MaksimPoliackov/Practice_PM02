﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            new LoginForm_2().Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}

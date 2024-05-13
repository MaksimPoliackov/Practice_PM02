using Medical_Laboratory.Admin_Dashboard;
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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void doctorsBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Doctors_ ad = new Admin_Doctors_();
            ad.ShowDialog();
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           Admin_Patients_ ap = new Admin_Patients_();
            ap.ShowDialog();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Staff_ ad = new Admin_Staff_();
            ad.ShowDialog();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Home homePage = new Home();
            this.Hide();
            homePage.Show();
        }

        private void appointmentBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           Admin_Appointment_ ad = new Admin_Appointment_();
            ad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Generate_Barcode ad = new Generate_Barcode();
            ad.ShowDialog();
        }
    }
}

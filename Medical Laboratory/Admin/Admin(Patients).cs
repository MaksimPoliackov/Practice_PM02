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

namespace Medical_Laboratory.Admin_Dashboard
{
    public partial class Admin_Patients_ : Form
    {
        public Admin_Patients_()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main_Page mp = new Main_Page();
            mp.ShowDialog();
        }

        private void Admin_Patients__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medical_LaboratoryDataSet._Пациенты__Patients_". При необходимости она может быть перемещена или удалена.
            this.пациенты__Patients_TableAdapter.Fill(this.medical_LaboratoryDataSet._Пациенты__Patients_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medical_LaboratoryDataSet1._Пациенты__Patients_". При необходимости она может быть перемещена или удалена.
        }

        private void patientsBtn_Click_1(object sender, EventArgs e)
        {  
            this.Visible = false;
            Admin_Patients_ ap = new Admin_Patients_();
            ap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Doctors_ ad = new Admin_Doctors_();
            ad.ShowDialog();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Staff_ ad = new Admin_Staff_();
            ad.ShowDialog();
        }

        private void appointmentBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Appointment_ ad = new Admin_Appointment_();
            ad.ShowDialog();
        }

        private void Barcode_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Generate_Barcode ad = new Generate_Barcode();
            ad.ShowDialog();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.Fill(this.medical_LaboratoryDataSet.User);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Report_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Gene ad = new Report();
            ad.ShowDialog();
        }
    }
}

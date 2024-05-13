using Medical_Laboratory.Admin_Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical_Laboratory
{
    public partial class Admin_Doctors_ : Form
    {
        public Admin_Doctors_()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-VNN5HQ9\\SQLEXPRESS;AttachDbFilename=C:\\Games\\Medical Laboratory\\Medical Laboratory.mdf;Integrated Security=True;Connect Timeout=30";
        private void Admin_Doctors__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medical_LaboratoryDataSet._Врачи__Doctors_". При необходимости она может быть перемещена или удалена.
            this.врачи__Doctors_TableAdapter.Fill(this.medical_LaboratoryDataSet._Врачи__Doctors_);
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GetData()
        {
          
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main_Page mp = new Main_Page();
            mp.ShowDialog();
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

        private void doctorsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Staff_ ad = new Admin_Staff_();
            ad.ShowDialog();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.врачи__Doctors_TableAdapter.Fill(this.medical_LaboratoryDataSet._Врачи__Doctors_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void appointmentBtn_Click(object sender, EventArgs e)
        {

        }

        private void Barcode_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Generate_Barcode ad = new Generate_Barcode();
            ad.ShowDialog();
        }
    }
}

﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medical_Laboratory.Forms.Dashboard.Reports
{
    public partial class InvoiceView : Form
    {
        private string apptID;

        public InvoiceView(string apptID)
        {
            InitializeComponent();
            this.apptID = apptID;
        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {
            string selectQuery =
                "SELECT apt.id, Patients.first_name + ' ' + Patients.last_name AS Patient, "
                + "apt.appt_number, apt.payment_status, apt.created_at, "
                + "sch.start_date, sch.location, sch.room, "
                + "Users.first_name + ' ' + Users.last_name AS Doctor, "
                + "Payments.payment_method, Payments.total, Payments.balance "
                + "FROM Appointments as apt "
                + "INNER JOIN Schedules AS sch ON apt.schedule_id = sch.id "
                + "INNER JOIN Users ON sch.doctor_id = Users.id "
                + "INNER JOIN Patients ON apt.patient_id = Patients.id "
                + "INNER JOIN Payments on apt.id = Payments.appointment_id "
                + "WHERE apt.id = @id";
            string selectChargesQuery = "SELECT title, amount FROM Appointment_Charges WHERE appointment_id = @id";


            SqlCommand sqlCommand = new SqlCommand(selectQuery);
            sqlCommand.Parameters.AddWithValue("@id", apptID);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //FETCH CHARGES
            SqlCommand chargesCmd = new SqlCommand(selectChargesQuery);
            chargesCmd.Parameters.AddWithValue("@id", apptID);
            SqlDataAdapter chargesAdapter = new SqlDataAdapter(chargesCmd);
            DataTable chargesTable = new DataTable();
            chargesAdapter.Fill(chargesTable);

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;

namespace Medical_Laboratory.Admin
{
    public partial class ReportForm : Form
    {
        private ReportViewer reportViewer;
        private string selectDocQuery =
            "SELECT * FROM Users "
            + "INNER JOIN DoctorProfiles ON Users.id = DoctorProfiles.user_id "
            + "WHERE Role = 'doctor' ";
        private ReportViewer reportsView;

        public ReportForm()
        {
            InitializeComponent();
            reportViewer = reportsView;
        }


        public ReportForm(ReportViewer reportViewer, string selectDocQuery, ReportViewer reportsView)
        {
            this.reportViewer = reportViewer;
            this.selectDocQuery = selectDocQuery;
            this.reportsView = reportsView;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            //GENERATE DOCTORS REPORT ON FORM LOAD
            GenerateReport(
                selectDocQuery,
                "DoctorsDataSet",
                "HealthCare_Plus.Forms.Dashboard.Reports.DoctorsReport.rdlc"
            );
        }

        private void DoctorsReportBtn_Click(object sender, EventArgs e)
        {
            GenerateReport(
                selectDocQuery,
                "DoctorsDataSet",
                "HealthCare_Plus.Forms.Dashboard.Reports.DoctorsReport.rdlc"
            );
        }

        private void PatientsReportBtn_Click(object sender, EventArgs e)
        {
            string selectPatiQuery = "SELECT * FROM Patients";
            GenerateReport(
                selectPatiQuery,
                "PatientDataSet",
                "HealthCare_Plus.Forms.Dashboard.Reports.PatientsReport.rdlc"
            );
        }

        private void PaymentsReportBtn_Click(object sender, EventArgs e)
        {
            string selectPaymentsQuery = "SELECT * FROM Payments";
            GenerateReport(
                selectPaymentsQuery,
                "PaymentsDataSet",
                "HealthCare_Plus.Forms.Dashboard.Reports.PaymentsReport.rdlc"
            );
        }

        private void GenerateReport(string query, string datSetName, string reportPath)
        {
            try
            {
                reportViewer.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource(datSetName);
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportEmbeddedResource = reportViewer.LocalReport.ReportEmbeddedResource =
                    reportPath;
            }
            catch { }
        }
        private void reportsView_Load(object sender, EventArgs e)
        {

        }

        private void Title_label_Click(object sender, EventArgs e)
        {

        }

        private void BodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BodyPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

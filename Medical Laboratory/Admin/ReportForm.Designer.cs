namespace Medical_Laboratory.Admin
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.medical_LaboratoryDataSet1 = new Medical_Laboratory.Medical_LaboratoryDataSet();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.PaymentsReportBtn = new System.Windows.Forms.Button();
            this.PatientsReportBtn = new System.Windows.Forms.Button();
            this.DoctorsReportBtn = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.medical_LaboratoryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // medical_LaboratoryDataSet1
            // 
            this.medical_LaboratoryDataSet1.DataSetName = "Medical_LaboratoryDataSet";
            this.medical_LaboratoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BodyPanel
            // 
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 178);
            this.BodyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(840, 311);
            this.BodyPanel.TabIndex = 31;
            this.BodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BodyPanel_Paint_1);
            // 
            // PaymentsReportBtn
            // 
            this.PaymentsReportBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentsReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.PaymentsReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentsReportBtn.FlatAppearance.BorderSize = 0;
            this.PaymentsReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentsReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsReportBtn.Location = new System.Drawing.Point(612, 78);
            this.PaymentsReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PaymentsReportBtn.Name = "PaymentsReportBtn";
            this.PaymentsReportBtn.Size = new System.Drawing.Size(208, 47);
            this.PaymentsReportBtn.TabIndex = 29;
            this.PaymentsReportBtn.Text = "Payments Report";
            this.PaymentsReportBtn.UseVisualStyleBackColor = false;
            // 
            // PatientsReportBtn
            // 
            this.PatientsReportBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PatientsReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.PatientsReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientsReportBtn.FlatAppearance.BorderSize = 0;
            this.PatientsReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientsReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsReportBtn.Location = new System.Drawing.Point(372, 78);
            this.PatientsReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PatientsReportBtn.Name = "PatientsReportBtn";
            this.PatientsReportBtn.Size = new System.Drawing.Size(208, 47);
            this.PatientsReportBtn.TabIndex = 28;
            this.PatientsReportBtn.Text = "Patients Report";
            this.PatientsReportBtn.UseVisualStyleBackColor = false;
            // 
            // DoctorsReportBtn
            // 
            this.DoctorsReportBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DoctorsReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.DoctorsReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorsReportBtn.FlatAppearance.BorderSize = 0;
            this.DoctorsReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorsReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorsReportBtn.Location = new System.Drawing.Point(132, 78);
            this.DoctorsReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DoctorsReportBtn.Name = "DoctorsReportBtn";
            this.DoctorsReportBtn.Size = new System.Drawing.Size(208, 47);
            this.DoctorsReportBtn.TabIndex = 27;
            this.DoctorsReportBtn.Text = "Doctors Report";
            this.DoctorsReportBtn.UseVisualStyleBackColor = false;
            this.DoctorsReportBtn.Click += new System.EventHandler(this.DoctorsReportBtn_Click);
            // 
            // Title_label
            // 
            this.Title_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(382, 24);
            this.Title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(126, 18);
            this.Title_label.TabIndex = 26;
            this.Title_label.Text = "Generate Reports";
            // 
            // TopPanel
            // 
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(840, 178);
            this.TopPanel.TabIndex = 30;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 489);
            this.ControlBox = false;
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.PaymentsReportBtn);
            this.Controls.Add(this.PatientsReportBtn);
            this.Controls.Add(this.DoctorsReportBtn);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.medical_LaboratoryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Medical_LaboratoryDataSet medical_LaboratoryDataSet1;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Button PaymentsReportBtn;
        private System.Windows.Forms.Button PatientsReportBtn;
        private System.Windows.Forms.Button DoctorsReportBtn;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Panel TopPanel;
    }
}
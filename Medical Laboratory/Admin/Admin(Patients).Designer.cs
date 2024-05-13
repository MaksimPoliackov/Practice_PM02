namespace Medical_Laboratory.Admin_Dashboard
{
    partial class Admin_Patients_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Patients_));
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalLaboratoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.врачиDoctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пациентыPatientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.medical_LaboratoryDataSet = new Medical_Laboratory.Medical_LaboratoryDataSet();
            this.пациентыPatientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.avatarImage = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.welcome_text = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.Barcode = new System.Windows.Forms.Button();
            this.appointmentBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.patientsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.doctorsBtn = new System.Windows.Forms.Button();
            this.пациентыPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентыPatientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.пациенты__Patients_TableAdapter = new Medical_Laboratory.Medical_LaboratoryDataSetTableAdapters.Пациенты__Patients_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalLaboratoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDoctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыPatientsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_LaboratoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыPatientsBindingSource1)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).BeginInit();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыPatientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыPatientsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(728, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 43;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // врачиDoctorsBindingSource
            // 
            this.врачиDoctorsBindingSource.DataMember = "Врачи (Doctors)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientidDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.пациентыPatientsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(206, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 359);
            this.dataGridView1.TabIndex = 42;
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "Patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "Patient_id";
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            this.patientidDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone_number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // пациентыPatientsBindingSource3
            // 
            this.пациентыPatientsBindingSource3.DataMember = "Пациенты (Patients)";
            this.пациентыPatientsBindingSource3.DataSource = this.medical_LaboratoryDataSet;
            // 
            // medical_LaboratoryDataSet
            // 
            this.medical_LaboratoryDataSet.DataSetName = "Medical_LaboratoryDataSet";
            this.medical_LaboratoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пациентыPatientsBindingSource1
            // 
            this.пациентыPatientsBindingSource1.DataMember = "Пациенты (Patients)";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(90)))));
            this.headerPanel.Controls.Add(this.avatarImage);
            this.headerPanel.Controls.Add(this.username_label);
            this.headerPanel.Controls.Add(this.welcome_text);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(200, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(640, 69);
            this.headerPanel.TabIndex = 39;
            // 
            // avatarImage
            // 
            this.avatarImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarImage.ErrorImage = null;
            this.avatarImage.Image = ((System.Drawing.Image)(resources.GetObject("avatarImage.Image")));
            this.avatarImage.InitialImage = null;
            this.avatarImage.Location = new System.Drawing.Point(578, 10);
            this.avatarImage.Name = "avatarImage";
            this.avatarImage.Size = new System.Drawing.Size(38, 35);
            this.avatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarImage.TabIndex = 12;
            this.avatarImage.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(572, 48);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(47, 13);
            this.username_label.TabIndex = 13;
            this.username_label.Text = "System";
            // 
            // welcome_text
            // 
            this.welcome_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.ForeColor = System.Drawing.Color.White;
            this.welcome_text.Location = new System.Drawing.Point(244, 26);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(152, 20);
            this.welcome_text.TabIndex = 11;
            this.welcome_text.Text = "Admin Dashboard";
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.logoPanel.Controls.Add(this.logoImage);
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 69);
            this.logoPanel.TabIndex = 40;
            // 
            // logoImage
            // 
            this.logoImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(0, 0);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(200, 69);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(0, 451);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(200, 38);
            this.logout_btn.TabIndex = 14;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.navigationPanel.Controls.Add(this.Barcode);
            this.navigationPanel.Controls.Add(this.appointmentBtn);
            this.navigationPanel.Controls.Add(this.staffBtn);
            this.navigationPanel.Controls.Add(this.patientsBtn);
            this.navigationPanel.Controls.Add(this.button1);
            this.navigationPanel.Controls.Add(this.logout_btn);
            this.navigationPanel.Controls.Add(this.doctorsBtn);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(200, 489);
            this.navigationPanel.TabIndex = 41;
            // 
            // Barcode
            // 
            this.Barcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.Barcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Barcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barcode.FlatAppearance.BorderSize = 0;
            this.Barcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode.ForeColor = System.Drawing.Color.White;
            this.Barcode.Image = ((System.Drawing.Image)(resources.GetObject("Barcode.Image")));
            this.Barcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Barcode.Location = new System.Drawing.Point(0, 300);
            this.Barcode.Name = "Barcode";
            this.Barcode.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Barcode.Size = new System.Drawing.Size(200, 60);
            this.Barcode.TabIndex = 19;
            this.Barcode.Text = "Barcode";
            this.Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Barcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Barcode.UseVisualStyleBackColor = false;
            this.Barcode.Click += new System.EventHandler(this.Barcode_Click);
            // 
            // appointmentBtn
            // 
            this.appointmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.appointmentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appointmentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentBtn.FlatAppearance.BorderSize = 0;
            this.appointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentBtn.ForeColor = System.Drawing.Color.White;
            this.appointmentBtn.Image = ((System.Drawing.Image)(resources.GetObject("appointmentBtn.Image")));
            this.appointmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentBtn.Location = new System.Drawing.Point(0, 240);
            this.appointmentBtn.Name = "appointmentBtn";
            this.appointmentBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.appointmentBtn.Size = new System.Drawing.Size(200, 60);
            this.appointmentBtn.TabIndex = 18;
            this.appointmentBtn.Text = "Appointment";
            this.appointmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appointmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.appointmentBtn.UseVisualStyleBackColor = false;
            this.appointmentBtn.Click += new System.EventHandler(this.appointmentBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.staffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffBtn.FlatAppearance.BorderSize = 0;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.ForeColor = System.Drawing.Color.White;
            this.staffBtn.Image = ((System.Drawing.Image)(resources.GetObject("staffBtn.Image")));
            this.staffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Location = new System.Drawing.Point(0, 180);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.staffBtn.Size = new System.Drawing.Size(200, 60);
            this.staffBtn.TabIndex = 17;
            this.staffBtn.Text = "Staff";
            this.staffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // patientsBtn
            // 
            this.patientsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.patientsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientsBtn.FlatAppearance.BorderSize = 0;
            this.patientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsBtn.ForeColor = System.Drawing.Color.White;
            this.patientsBtn.Image = ((System.Drawing.Image)(resources.GetObject("patientsBtn.Image")));
            this.patientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.Location = new System.Drawing.Point(0, 120);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.patientsBtn.Size = new System.Drawing.Size(200, 60);
            this.patientsBtn.TabIndex = 16;
            this.patientsBtn.Text = "Patients";
            this.patientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientsBtn.UseVisualStyleBackColor = false;
            this.patientsBtn.Click += new System.EventHandler(this.patientsBtn_Click_1);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 60);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "Doctors";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctorsBtn
            // 
            this.doctorsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.doctorsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.doctorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorsBtn.FlatAppearance.BorderSize = 0;
            this.doctorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsBtn.ForeColor = System.Drawing.Color.White;
            this.doctorsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorsBtn.Location = new System.Drawing.Point(0, 0);
            this.doctorsBtn.Name = "doctorsBtn";
            this.doctorsBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.doctorsBtn.Size = new System.Drawing.Size(200, 60);
            this.doctorsBtn.TabIndex = 1;
            this.doctorsBtn.Text = "Doctors";
            this.doctorsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doctorsBtn.UseVisualStyleBackColor = false;
            // 
            // пациентыPatientsBindingSource
            // 
            this.пациентыPatientsBindingSource.DataMember = "Пациенты (Patients)";
            // 
            // пациентыPatientsBindingSource2
            // 
            this.пациентыPatientsBindingSource2.DataMember = "Пациенты (Patients)";
            // 
            // пациенты__Patients_TableAdapter
            // 
            this.пациенты__Patients_TableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Patients_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 489);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.navigationPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_Patients_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Patients_";
            this.Load += new System.EventHandler(this.Admin_Patients__Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalLaboratoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDoctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыPatientsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_LaboratoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыPatientsBindingSource1)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).EndInit();
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.пациентыPatientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыPatientsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.BindingSource medicalLaboratoryDataSetBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource врачиDoctorsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox avatarImage;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button doctorsBtn;
        private System.Windows.Forms.BindingSource пациентыPatientsBindingSource;
        private System.Windows.Forms.BindingSource пациентыPatientsBindingSource1;
        private System.Windows.Forms.BindingSource пациентыPatientsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button appointmentBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button patientsBtn;
        private System.Windows.Forms.Button button1;
        private Medical_LaboratoryDataSet medical_LaboratoryDataSet;
        private System.Windows.Forms.BindingSource пациентыPatientsBindingSource3;
        private Medical_LaboratoryDataSetTableAdapters.Пациенты__Patients_TableAdapter пациенты__Patients_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button Barcode;
    }
}
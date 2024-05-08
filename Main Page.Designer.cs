namespace Medical_Laboratory
{
    partial class Main_Page
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.username_label = new System.Windows.Forms.Label();
            this.welcome_text = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.appointmentBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.patientsBtn = new System.Windows.Forms.Button();
            this.doctorsBtn = new System.Windows.Forms.Button();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.avatarImage = new System.Windows.Forms.PictureBox();
            this.headerPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(90)))));
            this.headerPanel.Controls.Add(this.avatarImage);
            this.headerPanel.Controls.Add(this.username_label);
            this.headerPanel.Controls.Add(this.welcome_text);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(840, 69);
            this.headerPanel.TabIndex = 1;
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(772, 48);
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
            this.welcome_text.Location = new System.Drawing.Point(344, 26);
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
            this.logoPanel.TabIndex = 2;
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.navigationPanel.Controls.Add(this.reportsBtn);
            this.navigationPanel.Controls.Add(this.logout_btn);
            this.navigationPanel.Controls.Add(this.appointmentBtn);
            this.navigationPanel.Controls.Add(this.staffBtn);
            this.navigationPanel.Controls.Add(this.patientsBtn);
            this.navigationPanel.Controls.Add(this.doctorsBtn);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 69);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(200, 420);
            this.navigationPanel.TabIndex = 16;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(97)))));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(0, 382);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(200, 38);
            this.logout_btn.TabIndex = 14;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.reportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.White;
            this.reportsBtn.Image = global::Medical_Laboratory.Properties.Resources.user_doctor_solid;
            this.reportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsBtn.Location = new System.Drawing.Point(0, 240);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.reportsBtn.Size = new System.Drawing.Size(200, 60);
            this.reportsBtn.TabIndex = 5;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportsBtn.UseVisualStyleBackColor = false;
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
            this.appointmentBtn.Image = global::Medical_Laboratory.Properties.Resources.appoinment_icon;
            this.appointmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentBtn.Location = new System.Drawing.Point(0, 180);
            this.appointmentBtn.Name = "appointmentBtn";
            this.appointmentBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.appointmentBtn.Size = new System.Drawing.Size(200, 60);
            this.appointmentBtn.TabIndex = 4;
            this.appointmentBtn.Text = "Appointment";
            this.appointmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appointmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.appointmentBtn.UseVisualStyleBackColor = false;
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
            this.staffBtn.Image = global::Medical_Laboratory.Properties.Resources.staff_icon;
            this.staffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Location = new System.Drawing.Point(0, 120);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.staffBtn.Size = new System.Drawing.Size(200, 60);
            this.staffBtn.TabIndex = 3;
            this.staffBtn.Text = "Staff";
            this.staffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staffBtn.UseVisualStyleBackColor = false;
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
            this.patientsBtn.Image = global::Medical_Laboratory.Properties.Resources.patient_icon;
            this.patientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.Location = new System.Drawing.Point(0, 60);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.patientsBtn.Size = new System.Drawing.Size(200, 60);
            this.patientsBtn.TabIndex = 2;
            this.patientsBtn.Text = "Patients";
            this.patientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientsBtn.UseVisualStyleBackColor = false;
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
            this.doctorsBtn.Image = global::Medical_Laboratory.Properties.Resources.user_doctor_solid;
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
            // logoImage
            // 
            this.logoImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoImage.Image = global::Medical_Laboratory.Properties.Resources.medicine;
            this.logoImage.Location = new System.Drawing.Point(0, 0);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(200, 69);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // avatarImage
            // 
            this.avatarImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarImage.Image = global::Medical_Laboratory.Properties.Resources.user;
            this.avatarImage.Location = new System.Drawing.Point(778, 10);
            this.avatarImage.Name = "avatarImage";
            this.avatarImage.Size = new System.Drawing.Size(38, 35);
            this.avatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarImage.TabIndex = 12;
            this.avatarImage.TabStop = false;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 489);
            this.ControlBox = false;
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Page";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox avatarImage;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button appointmentBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button patientsBtn;
        private System.Windows.Forms.Button doctorsBtn;
    }
}
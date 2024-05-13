namespace Medical_Laboratory
{
    partial class Home
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
            this.admin_login_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.welcome_text = new System.Windows.Forms.Label();
            this.welcome_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_image)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_login_btn
            // 
            this.admin_login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.admin_login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_login_btn.FlatAppearance.BorderSize = 0;
            this.admin_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_login_btn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_btn.ForeColor = System.Drawing.Color.White;
            this.admin_login_btn.Location = new System.Drawing.Point(388, 360);
            this.admin_login_btn.Name = "admin_login_btn";
            this.admin_login_btn.Size = new System.Drawing.Size(208, 96);
            this.admin_login_btn.TabIndex = 5;
            this.admin_login_btn.Text = "Admin Login";
            this.admin_login_btn.UseVisualStyleBackColor = false;
            this.admin_login_btn.Click += new System.EventHandler(this.admin_login_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(174, 360);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(208, 96);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Staff Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // welcome_text
            // 
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.ForeColor = System.Drawing.Color.Black;
            this.welcome_text.Location = new System.Drawing.Point(265, 24);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(260, 20);
            this.welcome_text.TabIndex = 3;
            this.welcome_text.Text = "Welcome to Medical Laboratory";
            // 
            // welcome_image
            // 
            this.welcome_image.Image = global::Medical_Laboratory.Properties.Resources.receptionist;
            this.welcome_image.Location = new System.Drawing.Point(241, 47);
            this.welcome_image.Name = "welcome_image";
            this.welcome_image.Size = new System.Drawing.Size(287, 296);
            this.welcome_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.welcome_image.TabIndex = 4;
            this.welcome_image.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.ControlBox = false;
            this.Controls.Add(this.admin_login_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.welcome_image);
            this.Controls.Add(this.welcome_text);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.welcome_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_login_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox welcome_image;
        private System.Windows.Forms.Label welcome_text;
    }
}
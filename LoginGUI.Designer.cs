﻿namespace HospitalManagementSystem
{
    partial class LoginGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            rjBtnPatientLogin = new RJButton.RJButton();
            rjBtnDoctorLogin = new RJButton.RJButton();
            rjBtnSecretaryLogin = new RJButton.RJButton();
            rjBtnAdminLogin = new RJButton.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(rjBtnAdminLogin);
            panel1.Controls.Add(rjBtnSecretaryLogin);
            panel1.Controls.Add(rjBtnDoctorLogin);
            panel1.Controls.Add(rjBtnPatientLogin);
            panel1.Location = new Point(479, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 264);
            panel1.TabIndex = 1;
            // 
            // rjBtnPatientLogin
            // 
            rjBtnPatientLogin.BackColor = Color.Salmon;
            rjBtnPatientLogin.BackgroundColor = Color.Salmon;
            rjBtnPatientLogin.BorderColor = Color.PaleVioletRed;
            rjBtnPatientLogin.BorderRadius = 20;
            rjBtnPatientLogin.BorderSize = 0;
            rjBtnPatientLogin.Dock = DockStyle.Top;
            rjBtnPatientLogin.FlatAppearance.BorderSize = 0;
            rjBtnPatientLogin.FlatStyle = FlatStyle.Flat;
            rjBtnPatientLogin.Font = new Font("Yu Gothic UI Semibold", 13F);
            rjBtnPatientLogin.ForeColor = Color.White;
            rjBtnPatientLogin.Image = (Image)resources.GetObject("rjBtnPatientLogin.Image");
            rjBtnPatientLogin.ImageAlign = ContentAlignment.MiddleLeft;
            rjBtnPatientLogin.Location = new Point(0, 0);
            rjBtnPatientLogin.Name = "rjBtnPatientLogin";
            rjBtnPatientLogin.Size = new Size(372, 66);
            rjBtnPatientLogin.TabIndex = 0;
            rjBtnPatientLogin.Text = "Patient Login";
            rjBtnPatientLogin.TextColor = Color.White;
            rjBtnPatientLogin.UseVisualStyleBackColor = false;
            // 
            // rjBtnDoctorLogin
            // 
            rjBtnDoctorLogin.BackColor = Color.Salmon;
            rjBtnDoctorLogin.BackgroundColor = Color.Salmon;
            rjBtnDoctorLogin.BorderColor = Color.PaleVioletRed;
            rjBtnDoctorLogin.BorderRadius = 20;
            rjBtnDoctorLogin.BorderSize = 0;
            rjBtnDoctorLogin.Dock = DockStyle.Top;
            rjBtnDoctorLogin.FlatAppearance.BorderSize = 0;
            rjBtnDoctorLogin.FlatStyle = FlatStyle.Flat;
            rjBtnDoctorLogin.Font = new Font("Yu Gothic UI Semibold", 13F);
            rjBtnDoctorLogin.ForeColor = Color.White;
            rjBtnDoctorLogin.Image = (Image)resources.GetObject("rjBtnDoctorLogin.Image");
            rjBtnDoctorLogin.ImageAlign = ContentAlignment.MiddleLeft;
            rjBtnDoctorLogin.Location = new Point(0, 66);
            rjBtnDoctorLogin.Name = "rjBtnDoctorLogin";
            rjBtnDoctorLogin.Size = new Size(372, 66);
            rjBtnDoctorLogin.TabIndex = 1;
            rjBtnDoctorLogin.Text = "Doctor Login";
            rjBtnDoctorLogin.TextColor = Color.White;
            rjBtnDoctorLogin.UseVisualStyleBackColor = false;
            // 
            // rjBtnSecretaryLogin
            // 
            rjBtnSecretaryLogin.BackColor = Color.Salmon;
            rjBtnSecretaryLogin.BackgroundColor = Color.Salmon;
            rjBtnSecretaryLogin.BorderColor = Color.PaleVioletRed;
            rjBtnSecretaryLogin.BorderRadius = 20;
            rjBtnSecretaryLogin.BorderSize = 0;
            rjBtnSecretaryLogin.Dock = DockStyle.Top;
            rjBtnSecretaryLogin.FlatAppearance.BorderSize = 0;
            rjBtnSecretaryLogin.FlatStyle = FlatStyle.Flat;
            rjBtnSecretaryLogin.Font = new Font("Yu Gothic UI Semibold", 13F);
            rjBtnSecretaryLogin.ForeColor = Color.White;
            rjBtnSecretaryLogin.Image = (Image)resources.GetObject("rjBtnSecretaryLogin.Image");
            rjBtnSecretaryLogin.ImageAlign = ContentAlignment.MiddleLeft;
            rjBtnSecretaryLogin.Location = new Point(0, 132);
            rjBtnSecretaryLogin.Name = "rjBtnSecretaryLogin";
            rjBtnSecretaryLogin.Size = new Size(372, 66);
            rjBtnSecretaryLogin.TabIndex = 2;
            rjBtnSecretaryLogin.Text = "Secretary Login";
            rjBtnSecretaryLogin.TextColor = Color.White;
            rjBtnSecretaryLogin.UseVisualStyleBackColor = false;
            // 
            // rjBtnAdminLogin
            // 
            rjBtnAdminLogin.BackColor = Color.Salmon;
            rjBtnAdminLogin.BackgroundColor = Color.Salmon;
            rjBtnAdminLogin.BorderColor = Color.PaleVioletRed;
            rjBtnAdminLogin.BorderRadius = 20;
            rjBtnAdminLogin.BorderSize = 0;
            rjBtnAdminLogin.Dock = DockStyle.Top;
            rjBtnAdminLogin.FlatAppearance.BorderSize = 0;
            rjBtnAdminLogin.FlatStyle = FlatStyle.Flat;
            rjBtnAdminLogin.Font = new Font("Yu Gothic UI Semibold", 13F);
            rjBtnAdminLogin.ForeColor = Color.White;
            rjBtnAdminLogin.Image = (Image)resources.GetObject("rjBtnAdminLogin.Image");
            rjBtnAdminLogin.ImageAlign = ContentAlignment.MiddleLeft;
            rjBtnAdminLogin.Location = new Point(0, 198);
            rjBtnAdminLogin.Name = "rjBtnAdminLogin";
            rjBtnAdminLogin.Size = new Size(372, 66);
            rjBtnAdminLogin.TabIndex = 3;
            rjBtnAdminLogin.Text = "Admin Login";
            rjBtnAdminLogin.TextColor = Color.White;
            rjBtnAdminLogin.UseVisualStyleBackColor = false;
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 461);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "LoginGUI";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private RJButton.RJButton rjBtnPatientLogin;
        private RJButton.RJButton rjBtnAdminLogin;
        private RJButton.RJButton rjBtnSecretaryLogin;
        private RJButton.RJButton rjBtnDoctorLogin;
    }
}

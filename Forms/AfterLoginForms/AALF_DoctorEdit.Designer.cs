﻿namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class AALF_DoctorEdit
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
            buttonAALF_DoctorSave = new CustomTools.RJButton.RJButton();
            buttonAALF_DoctorDelete = new CustomTools.RJButton.RJButton();
            buttonAALF_DoctorUpdate = new CustomTools.RJButton.RJButton();
            labelAALF_Branch = new Label();
            labelAALF_phon = new Label();
            labelAALF_ID = new Label();
            labelAALF_Name = new Label();
            labelAALF_Pass = new Label();
            labelAALF_Surnam = new Label();
            labelAALF_Doc = new Label();
            dataGridViewAALF_Doctor = new DataGridView();
            textboxAALF_DoctorId = new TextBox();
            textboxAALF_DoctorName = new TextBox();
            textboxAALF_DoctorSurname = new TextBox();
            textboxAALF_DoctorPhone = new TextBox();
            textboxAALF_DoctorPassword = new TextBox();
            textboxAALF_DoctorBranch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_Doctor).BeginInit();
            SuspendLayout();
            // 
            // buttonAALF_DoctorSave
            // 
            buttonAALF_DoctorSave.BackColor = Color.Salmon;
            buttonAALF_DoctorSave.BackgroundColor = Color.Salmon;
            buttonAALF_DoctorSave.BorderColor = Color.Salmon;
            buttonAALF_DoctorSave.BorderRadius = 15;
            buttonAALF_DoctorSave.BorderSize = 0;
            buttonAALF_DoctorSave.FlatAppearance.BorderSize = 0;
            buttonAALF_DoctorSave.FlatStyle = FlatStyle.Flat;
            buttonAALF_DoctorSave.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_DoctorSave.ForeColor = Color.White;
            buttonAALF_DoctorSave.Location = new Point(169, 308);
            buttonAALF_DoctorSave.Name = "buttonAALF_DoctorSave";
            buttonAALF_DoctorSave.Size = new Size(250, 32);
            buttonAALF_DoctorSave.TabIndex = 72;
            buttonAALF_DoctorSave.Text = "Save";
            buttonAALF_DoctorSave.TextColor = Color.White;
            buttonAALF_DoctorSave.UseVisualStyleBackColor = false;
            buttonAALF_DoctorSave.Click += buttonAALF_DoctorSave_Click;
            // 
            // buttonAALF_DoctorDelete
            // 
            buttonAALF_DoctorDelete.BackColor = Color.Red;
            buttonAALF_DoctorDelete.BackgroundColor = Color.Red;
            buttonAALF_DoctorDelete.BorderColor = Color.Salmon;
            buttonAALF_DoctorDelete.BorderRadius = 10;
            buttonAALF_DoctorDelete.BorderSize = 0;
            buttonAALF_DoctorDelete.FlatAppearance.BorderSize = 0;
            buttonAALF_DoctorDelete.FlatStyle = FlatStyle.Flat;
            buttonAALF_DoctorDelete.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_DoctorDelete.ForeColor = Color.White;
            buttonAALF_DoctorDelete.Location = new Point(169, 344);
            buttonAALF_DoctorDelete.Name = "buttonAALF_DoctorDelete";
            buttonAALF_DoctorDelete.Size = new Size(89, 27);
            buttonAALF_DoctorDelete.TabIndex = 71;
            buttonAALF_DoctorDelete.Text = "Delete";
            buttonAALF_DoctorDelete.TextColor = Color.White;
            buttonAALF_DoctorDelete.UseVisualStyleBackColor = false;
            buttonAALF_DoctorDelete.Click += buttonAALF_DoctorDelete_Click;
            // 
            // buttonAALF_DoctorUpdate
            // 
            buttonAALF_DoctorUpdate.BackColor = Color.SkyBlue;
            buttonAALF_DoctorUpdate.BackgroundColor = Color.SkyBlue;
            buttonAALF_DoctorUpdate.BorderColor = Color.Salmon;
            buttonAALF_DoctorUpdate.BorderRadius = 10;
            buttonAALF_DoctorUpdate.BorderSize = 0;
            buttonAALF_DoctorUpdate.FlatAppearance.BorderSize = 0;
            buttonAALF_DoctorUpdate.FlatStyle = FlatStyle.Flat;
            buttonAALF_DoctorUpdate.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_DoctorUpdate.ForeColor = Color.White;
            buttonAALF_DoctorUpdate.Location = new Point(263, 344);
            buttonAALF_DoctorUpdate.Name = "buttonAALF_DoctorUpdate";
            buttonAALF_DoctorUpdate.Size = new Size(156, 27);
            buttonAALF_DoctorUpdate.TabIndex = 70;
            buttonAALF_DoctorUpdate.Text = "Update";
            buttonAALF_DoctorUpdate.TextColor = Color.White;
            buttonAALF_DoctorUpdate.UseVisualStyleBackColor = false;
            buttonAALF_DoctorUpdate.Click += buttonAALF_DoctorUpdate_Click;
            // 
            // labelAALF_Branch
            // 
            labelAALF_Branch.AutoSize = true;
            labelAALF_Branch.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Branch.Location = new Point(27, 260);
            labelAALF_Branch.Name = "labelAALF_Branch";
            labelAALF_Branch.Size = new Size(57, 20);
            labelAALF_Branch.TabIndex = 69;
            labelAALF_Branch.Text = "Branch";
            // 
            // labelAALF_phon
            // 
            labelAALF_phon.AutoSize = true;
            labelAALF_phon.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_phon.Location = new Point(25, 187);
            labelAALF_phon.Name = "labelAALF_phon";
            labelAALF_phon.Size = new Size(53, 20);
            labelAALF_phon.TabIndex = 68;
            labelAALF_phon.Text = "Phone";
            // 
            // labelAALF_ID
            // 
            labelAALF_ID.AutoSize = true;
            labelAALF_ID.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_ID.Location = new Point(27, 149);
            labelAALF_ID.Name = "labelAALF_ID";
            labelAALF_ID.Size = new Size(124, 20);
            labelAALF_ID.TabIndex = 67;
            labelAALF_ID.Text = "Identification No";
            // 
            // labelAALF_Name
            // 
            labelAALF_Name.AutoSize = true;
            labelAALF_Name.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Name.Location = new Point(27, 76);
            labelAALF_Name.Name = "labelAALF_Name";
            labelAALF_Name.Size = new Size(50, 20);
            labelAALF_Name.TabIndex = 66;
            labelAALF_Name.Text = "Name";
            // 
            // labelAALF_Pass
            // 
            labelAALF_Pass.AutoSize = true;
            labelAALF_Pass.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Pass.Location = new Point(27, 224);
            labelAALF_Pass.Name = "labelAALF_Pass";
            labelAALF_Pass.Size = new Size(73, 20);
            labelAALF_Pass.TabIndex = 61;
            labelAALF_Pass.Text = "Password";
            // 
            // labelAALF_Surnam
            // 
            labelAALF_Surnam.AutoSize = true;
            labelAALF_Surnam.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAALF_Surnam.Location = new Point(27, 110);
            labelAALF_Surnam.Name = "labelAALF_Surnam";
            labelAALF_Surnam.Size = new Size(70, 20);
            labelAALF_Surnam.TabIndex = 59;
            labelAALF_Surnam.Text = "Surname";
            // 
            // labelAALF_Doc
            // 
            labelAALF_Doc.AutoSize = true;
            labelAALF_Doc.Font = new Font("Yu Gothic UI Semibold", 13F);
            labelAALF_Doc.Location = new Point(27, 38);
            labelAALF_Doc.Name = "labelAALF_Doc";
            labelAALF_Doc.Size = new Size(69, 25);
            labelAALF_Doc.TabIndex = 57;
            labelAALF_Doc.Text = "Doctor";
            // 
            // dataGridViewAALF_Doctor
            // 
            dataGridViewAALF_Doctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAALF_Doctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAALF_Doctor.Location = new Point(426, 64);
            dataGridViewAALF_Doctor.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAALF_Doctor.Name = "dataGridViewAALF_Doctor";
            dataGridViewAALF_Doctor.RowHeadersWidth = 51;
            dataGridViewAALF_Doctor.Size = new Size(426, 304);
            dataGridViewAALF_Doctor.TabIndex = 56;
            dataGridViewAALF_Doctor.CellClick += dataGridViewAALF_Doctor_CellClick;
            dataGridViewAALF_Doctor.CellEndEdit += dataGridViewAALF_Doctor_CellEndEdit;
            dataGridViewAALF_Doctor.CellFormatting += dataGridViewAALF_Doctor_CellFormatting;
            // 
            // textboxAALF_DoctorId
            // 
            textboxAALF_DoctorId.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorId.Location = new Point(170, 148);
            textboxAALF_DoctorId.Name = "textboxAALF_DoctorId";
            textboxAALF_DoctorId.PlaceholderText = "ID";
            textboxAALF_DoctorId.Size = new Size(228, 24);
            textboxAALF_DoctorId.TabIndex = 75;
            textboxAALF_DoctorId.KeyPress += textboxAALF_DoctorId_KeyPress;
            // 
            // textboxAALF_DoctorName
            // 
            textboxAALF_DoctorName.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorName.Location = new Point(169, 74);
            textboxAALF_DoctorName.Name = "textboxAALF_DoctorName";
            textboxAALF_DoctorName.PlaceholderText = "Name";
            textboxAALF_DoctorName.Size = new Size(228, 24);
            textboxAALF_DoctorName.TabIndex = 76;
            // 
            // textboxAALF_DoctorSurname
            // 
            textboxAALF_DoctorSurname.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorSurname.Location = new Point(169, 108);
            textboxAALF_DoctorSurname.Name = "textboxAALF_DoctorSurname";
            textboxAALF_DoctorSurname.PlaceholderText = "Surname";
            textboxAALF_DoctorSurname.Size = new Size(228, 24);
            textboxAALF_DoctorSurname.TabIndex = 77;
            // 
            // textboxAALF_DoctorPhone
            // 
            textboxAALF_DoctorPhone.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorPhone.Location = new Point(169, 185);
            textboxAALF_DoctorPhone.Name = "textboxAALF_DoctorPhone";
            textboxAALF_DoctorPhone.PlaceholderText = "Phone Number";
            textboxAALF_DoctorPhone.Size = new Size(228, 24);
            textboxAALF_DoctorPhone.TabIndex = 78;
            textboxAALF_DoctorPhone.KeyPress += textboxAALF_DoctorPhone_KeyPress;
            // 
            // textboxAALF_DoctorPassword
            // 
            textboxAALF_DoctorPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorPassword.Location = new Point(170, 222);
            textboxAALF_DoctorPassword.Name = "textboxAALF_DoctorPassword";
            textboxAALF_DoctorPassword.PlaceholderText = "Password";
            textboxAALF_DoctorPassword.Size = new Size(228, 24);
            textboxAALF_DoctorPassword.TabIndex = 79;
            // 
            // textboxAALF_DoctorBranch
            // 
            textboxAALF_DoctorBranch.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_DoctorBranch.Location = new Point(169, 259);
            textboxAALF_DoctorBranch.Name = "textboxAALF_DoctorBranch";
            textboxAALF_DoctorBranch.PlaceholderText = "Branch";
            textboxAALF_DoctorBranch.Size = new Size(228, 24);
            textboxAALF_DoctorBranch.TabIndex = 80;
            // 
            // AALF_DoctorEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(871, 415);
            Controls.Add(textboxAALF_DoctorBranch);
            Controls.Add(textboxAALF_DoctorPassword);
            Controls.Add(textboxAALF_DoctorPhone);
            Controls.Add(textboxAALF_DoctorSurname);
            Controls.Add(textboxAALF_DoctorName);
            Controls.Add(textboxAALF_DoctorId);
            Controls.Add(buttonAALF_DoctorSave);
            Controls.Add(buttonAALF_DoctorDelete);
            Controls.Add(buttonAALF_DoctorUpdate);
            Controls.Add(labelAALF_Branch);
            Controls.Add(labelAALF_phon);
            Controls.Add(labelAALF_ID);
            Controls.Add(labelAALF_Name);
            Controls.Add(labelAALF_Pass);
            Controls.Add(labelAALF_Surnam);
            Controls.Add(labelAALF_Doc);
            Controls.Add(dataGridViewAALF_Doctor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AALF_DoctorEdit";
            Text = "AALF_DoctorEdit";
            Load += AALF_DoctorEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_Doctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton buttonAALF_DoctorSave;
        private CustomTools.RJButton.RJButton buttonAALF_DoctorDelete;
        private CustomTools.RJButton.RJButton buttonAALF_DoctorUpdate;
        private Label labelAALF_Branch;
        private Label labelAALF_phon;
        private Label labelAALF_ID;
        private Label labelAALF_Name;
        private Label labelAALF_Pass;
        private Label labelAALF_Surnam;
        private Label labelAALF_Doc;
        private DataGridView dataGridViewAALF_Doctor;
        private TextBox textboxAALF_DoctorId;
        private TextBox textboxAALF_DoctorName;
        private TextBox textboxAALF_DoctorSurname;
        private TextBox textboxAALF_DoctorPhone;
        private TextBox textboxAALF_DoctorPassword;
        private TextBox textboxAALF_DoctorBranch;
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Database;

namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    public partial class AALF_DoctorEdit : Form
    {
        public string doctorDB_ID { get; set; }
        HospitalDbContext context;
        public AALF_DoctorEdit()
        {
            InitializeComponent();
            context = new HospitalDbContext();
        }

        private void AALF_DoctorEdit_Load(object sender, EventArgs e)
        {
            Helper.Helper helper = new Helper.Helper();
            helper.loadDataDoctors(dataGridViewAALF_Doctor, context);

            dataGridViewAALF_Doctor.Columns["password"].ReadOnly = true;
        }

        private void textboxAALF_DoctorId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxAALF_DoctorId);
        }

        private void textboxAALF_DoctorPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxAALF_DoctorPhone);
        }

        private void buttonAALF_DoctorSave_Click(object sender, EventArgs e)
        {
            bool[] signUpControlArray = new bool[6];

            signUpControlArray[0] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_DoctorName);
            signUpControlArray[1] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_DoctorSurname);
            signUpControlArray[2] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_DoctorId);
            signUpControlArray[3] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_DoctorPhone);
            signUpControlArray[4] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_DoctorPassword);
            signUpControlArray[5] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_DoctorBranch);

            bool result = true;

            foreach (bool value in signUpControlArray)
            {
                result = result && value;
            }

            if (result)
            {
                if (!(textboxAALF_DoctorId.Text.Length < 11))
                {
                    Helper.PasswordHasher hasher = new Helper.PasswordHasher();
                    string hashedPassword = hasher.HashPassword(textboxAALF_DoctorPassword.Text);

                    using (var context = new HospitalDbContext())
                    {
                        Doctor newDoctor = new Doctor
                        {
                            name = textboxAALF_DoctorName.Text,
                            surname = textboxAALF_DoctorSurname.Text,
                            identification = textboxAALF_DoctorId.Text,
                            GSM_No = textboxAALF_DoctorPhone.Text,
                            password = hashedPassword,
                            branch = textboxAALF_DoctorBranch.Text,
                            averageEvaluationScore = 0
                        };
                        context.Doctors.Add(newDoctor);
                        context.SaveChanges();

                        MessageBox.Show("Database Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.Helper helper = new Helper.Helper();
                        helper.loadDataDoctors(dataGridViewAALF_Doctor, context);
                    }
                }
                else
                {
                    MessageBox.Show("Identification number must be 11 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are required for registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAALF_Doctor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewAALF_Doctor.Columns[e.ColumnIndex].Name == "password" && e.Value != null)
            {
                // Hücre değerini sansürle
                e.Value = new string('*', 5);
                e.FormattingApplied = true;
            }
        }

        private void dataGridViewAALF_Doctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewAALF_Doctor.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridViewAALF_Doctor.Rows[selectedRowIndex];

                string columnName = selectedRow.Cells["name"].Value.ToString();
                string columnSurname = selectedRow.Cells["surname"].Value.ToString();
                string columnID = selectedRow.Cells["identification"].Value.ToString();
                string columnPhone = selectedRow.Cells["GSM_No"].Value.ToString();
                string columnBranch = selectedRow.Cells["branch"].Value.ToString();

                this.doctorDB_ID = selectedRow.Cells["DoctorId"].Value.ToString();

                textboxAALF_DoctorName.Text = columnName;
                textboxAALF_DoctorSurname.Text = columnSurname;
                textboxAALF_DoctorId.Text = columnID;
                textboxAALF_DoctorPhone.Text = columnPhone;
                textboxAALF_DoctorBranch.Text = columnBranch;
            }
        }

        private void buttonAALF_DoctorDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.doctorDB_ID))
            {
                using (var context = new HospitalDbContext())
                {
                    context.deleteDoctorByID(Convert.ToInt32(this.doctorDB_ID));
                }
                Helper.Helper helper = new Helper.Helper();
                helper.loadDataDoctors(dataGridViewAALF_Doctor, context);
            }
            else
            {

            }
        }

        private void buttonAALF_DoctorUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new HospitalDbContext())
            {
                context.updateDoctorByID
                    (
                    Convert.ToInt32(this.doctorDB_ID),
                    textboxAALF_DoctorName.Text,
                    textboxAALF_DoctorSurname.Text,
                    textboxAALF_DoctorId.Text,
                    textboxAALF_DoctorPhone.Text,
                    textboxAALF_DoctorBranch.Text
                    );
                context.SaveChanges();
                Helper.Helper helper = new Helper.Helper();
                helper.loadDataDoctors(dataGridViewAALF_Doctor, context);
            }

        }

        private void dataGridViewAALF_Doctor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var doctorID = (int)dataGridViewAALF_Doctor.Rows[e.RowIndex].Cells["DoctorId"].Value;
            var updateValue = dataGridViewAALF_Doctor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            var columnName = dataGridViewAALF_Doctor.Columns[e.ColumnIndex].Name;

            var context = new HospitalDbContext();

            var doctors = context.Doctors.FirstOrDefault(p => p.DoctorId == doctorID);

            if (doctors != null)
            {
                switch (columnName)
                {
                    case "name":
                        doctors.name = updateValue;
                        break;
                    case "surname":
                        doctors.surname = updateValue;
                        break;
                    case "identification":
                        doctors.identification = updateValue;
                        break;
                    case "GSM_No":
                        doctors.GSM_No = updateValue;
                        break;
                    case "branch":
                        doctors.branch = updateValue;
                        break;
                }
                context.SaveChanges();
            }
        }
    }
}

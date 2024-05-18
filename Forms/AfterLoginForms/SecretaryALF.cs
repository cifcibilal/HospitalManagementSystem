﻿using HospitalManagementSystem.Forms.AfterLoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    public partial class SecretaryALF : Form
    {
        SALF_Appointments appointments;
        ALF_Information myinformation;
        SALF_MadeAppointment madeAppointment;

        Helper.Helper helper;
        public SecretaryALF()
        {
            InitializeComponent();
        }

        private void SecretaryALF_Load(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelSecretaryAlf);
            madeAppointment = new SALF_MadeAppointment();
            helper.formGoster(madeAppointment, madeAppointment.Name);

        }

        private void SecretaryALF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SALF_MainPageMakeAppointments_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelSecretaryAlf);
            madeAppointment = new SALF_MadeAppointment();
            helper.formGoster(madeAppointment, madeAppointment.Name);
        }

        private void SALF_MainPageAppointments_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelSecretaryAlf);
            appointments = new SALF_Appointments();
            helper.formGoster(appointments, appointments.Name);

        }

        private void SALF_MainPageInformation_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelSecretaryAlf);
            myinformation= new ALF_Information(panelSecretaryAlf);
            helper.formGoster(myinformation, myinformation.Name);
        }
    }
}

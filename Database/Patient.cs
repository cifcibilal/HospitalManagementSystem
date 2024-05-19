﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Database
{
    public class Patient 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string identification { get; set; }
        public string GSM_No { get; set; }
        public string password { get; set; }
        public string againPassword { get; set; }
    }
}

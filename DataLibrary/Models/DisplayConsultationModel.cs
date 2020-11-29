﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLibrary.Models
{
    public class DisplayConsultationModel
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Notes { get; set; }

        public string Medicines { get; set; }

        public int Days { get; set; }

        public bool MaramTherapyDone { get; set; }

        [Required]
        public int AmountCharged { get; set; }

        [Required]
        public int AmountReceived { get; set; }

        public int PatientId { get; set; }
    }
}

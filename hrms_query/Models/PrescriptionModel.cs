using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Models
{
    public class PrescriptionModel
    {

        public int PrescriptionId { get; set; } // Primary Key: Prescription_Id
        public int PatId { get; set; } // Foreign Key: pat_id
        public int DoctorId { get; set; } // Foreign Key: Docotr_id    
        public int MedicationId { get; set; } // Foreign Key Medication_id

        public string DoctorsNote { get; set; } 
        public DateTime IssuedDate { get; set; }   
        public DateTime CreatedAt { get; set; }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_query.Enums;

namespace hrms_query.Models
{
    internal class PatientsMedicalInfoModel
    {
        public int InfoId { get; set; }  // Primary Key and Foreign Key: info_Id
        public BloodType BloodType { get; set; }  
        public decimal Height { get; set; }   
        public decimal Weight { get; set; } 
        public PatientStatus PatientStatus { get; set; } 

        // Navigation Property
        public PatientModel Patient { get; set; }
    }

    // Enum for BloodType

}

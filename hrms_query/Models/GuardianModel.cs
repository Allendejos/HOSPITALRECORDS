using hrms_query.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Models
{
    public class GuardianModel
    {
        public int PatientId { get; set; } // Foreign Key from PatientModel
        public string G_FirstName { get; set; }
        public string G_MiddleName { get; set; }
        public string G_LastName { get; set; }
        public string G_Gender { get; set; }
        public string G_Relationship { get; set; }
        public string G_PhoneNumber { get; set; }
        public string G_Email { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


        public PatientModel Patient { get; set; }

    }
}

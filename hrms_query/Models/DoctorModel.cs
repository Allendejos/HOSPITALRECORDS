using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_query.Models.Enums;

namespace hrms_query.Models
{
    public class DoctorModel : PersonModel
    {
        public int DoctorId { get; set; }  // doctor_id (Primary Key)
        public int UserId { get; set; }
        public string Specialization { get; set; }  // specialization
        public string? LicenseNo { get; set; }  // licenseNo 
        public DateTime? CreatedAt { get; set; }  

    }
}

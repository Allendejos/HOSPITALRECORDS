using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_query.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace hrms_query.Models
{
    public class PatientModel
    {
        // Primary Key
        public int PatientId { get; set; }

        // Unique Identifier
        public string PatientCode { get; set; }

        // Personal Details
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Contact Details
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // Enum Fields
        public string Gender { get; set; }
        public string Religion { get; set; }

        // Additional Details
        public string Occupation { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Guardian Relationship
        public GuardianModel Guardian { get; set; }
    }


}


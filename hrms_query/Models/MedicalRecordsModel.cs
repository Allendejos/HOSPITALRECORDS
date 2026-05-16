using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Models
{
    public class MedicalRecordsModel
    {
        public int RecordsId { get; set; }   // Primary Key: records_id
        public int PatId { get; set; }   // Foreign Key: pat_id
        public string Diagnosis { get; set; }      
        public string Treatment { get; set; }       
        public int MedicationId { get; set; }       
        public string DoctorsNote { get; set; }    
        public DateTime VisitDate { get; set; }   

    }
}

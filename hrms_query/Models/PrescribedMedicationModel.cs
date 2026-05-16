using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Models
{
    internal class PrescribedMedicationModel
    {

        public int MedicationId { get; set; }  
        public int PatId { get; set; }               
        public string MedicationName { get; set; }   
        public string Dosage { get; set; }          
        public string Frequency { get; set; }      



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Models
{
    internal class MedicalHistoryModel
    {

        public int HistoryId { get; set; }  // Primary Key: history_id
        public int PatientId { get; set; }  // Foreign Key: pat_id
        public int MedicationId { get; set; }  // Foreign Key: medication_id
        public string DiagnosedWith { get; set; }  //  diagnosedWith
        public string DiagnosedWhere { get; set; }  //  diagnosedWhere
        public bool HasMaintenance { get; set; }   // hasMaintenace
        public DateTime DateOfDiagnosis { get; set; } // dateOfDiagnosis
    }
}

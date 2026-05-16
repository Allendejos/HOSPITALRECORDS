using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Models
{
    internal class MedicalCondition
    {
        public int ConditionId { get; set; }
        public int PatientId { get; set; }
        public string CondtionName { get; set; }
        public string ConditionDescription { get; set; }
        public DateTime DiagnosisDate { get; set; }

    }
}

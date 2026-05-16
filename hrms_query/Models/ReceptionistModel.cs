using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_query.Models.Enums;

namespace hrms_query.Models
{
    public class ReceptionistModel : PersonModel
    {
        public int ReceptionistId { get; set; }  // doctor_id (Primary Key)
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

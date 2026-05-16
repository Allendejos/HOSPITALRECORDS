using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Models
{
    internal class LogsModel
    {
        public int LogId { get; set; }
        public int UserId { get; set; }
        public int AdminId { get; set; }
        public string Action { get; set; }
        public DateTime ActionDate { get; set; }
    }
}

using hrms_query.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Models
{
    public class AdminModel
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt
        {
            get; set;
        }
    }
}

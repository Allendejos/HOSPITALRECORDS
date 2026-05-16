using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_query.Enums;


namespace hrms_query.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }

        public Role UserRole { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }

        public string? SessionToken { get; set; }

        public DateTime? TokenExpiration { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_query.Models;
using hrms_query.Models.Enums;
using MySql.Data.MySqlClient;

namespace hrms_query.Repositories
{
    public interface IRegisterRepository
    {
        Task<bool> IsUsernameTakenAsync(string username);
        Task<bool> IsEmailTakenAsync(string email);
        Task<bool> RegisterUserAsync(UserModel user, PersonModel person, string LicenseNo, string Specialization);
        Task<int> InsertUserAsync(UserModel user, MySqlTransaction transaction);
        Task<bool> InsertDoctorAsync(DoctorModel doctor, MySqlTransaction transaction);
        Task<bool> InsertNurseAsync(NurseModel nurse, MySqlTransaction transaction);
        Task<bool> InsertReceptionistAsync(ReceptionistModel recptionist, MySqlTransaction transaction);
        Task<bool> InsertAdminAsync(AdminModel admin, MySqlTransaction transaction);
        Task<bool> IsAccountAdminAsync(int id);
        Task<bool> IsAccountStaffAsync(int id);
    }
}

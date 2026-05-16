using hrms_query.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Repositories
{
    public interface ILoginRepository
    {
        // Authenticates if user credentials exists in the users table
        Task<string?> AuthenticateAsync(string usernameOrEmail, string password);

        // Gets the user by username from the users table
        Task<UserModel?> GetUserByUserIdAsync(int userId);

        //// Optional
        //string HashPassword(string password);
        ////
        //bool ValidatePassword(string enteredPassword, string storedHashedPassword);

        // Checks if the account is admin or not
        Task<bool> IsAccountAdminAsync(int userId);

        // Checks if the account is staff or 
        //Task<bool> IsAccountStaffAsync(int userId);
        // Checks if the username is already taken
        //Task<bool> IsUsernameTakenAsync(string usernameOrEmail);

        //// Checks if the email is already 
        //Task<bool> IsEmailTakenAsync(string email);

        Task<int> GetHoursBasedOnRole(string role);

        Task<bool> ClearUserToken(string token);
        Task<string?> GetRoleByUserId(int userId);
        string GenerateToken();
        Task<UserModel?> GetUserByTokenAsync(string token);
        Task UpdateUserTokenAsync(int? userId, string? token, DateTime? expiration);

    }
}

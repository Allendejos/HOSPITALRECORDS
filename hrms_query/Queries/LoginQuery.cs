using hrms_query.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hrms_query.Models;
using hrms_query.Enums;
using MySql.Data.MySqlClient;
using static hrms_query.Models.Enums.enumList;

namespace hrms_query.Repositories
{
    public class LoginQuery : ILoginRepository
    {
        private readonly IDbManager _dbManager;

        public LoginQuery(IDbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public async Task<string?> AuthenticateAsync(string usernameOrEmail, string password)
        {
            int? authenticated_UserId = null;
            string? GenToken = null;

            using (var connection = _dbManager.GetConnection())
            using (var command = new MySqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = "SELECT user_id FROM users " +
                                        "WHERE (username = @UsernameOrEmail OR email = @UsernameOrEmail) " +
                                        "AND password = @Password LIMIT 1";

                
                command.Parameters.AddWithValue("@UsernameOrEmail", usernameOrEmail);
                command.Parameters.AddWithValue("@Password", password);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        authenticated_UserId = reader.GetInt32(0); // Get user ID
                        GenToken = GenerateToken();
                        string? role = await GetRoleByUserId(authenticated_UserId.Value);
                        DateTime expiration = DateTime.UtcNow.AddHours(await GetHoursBasedOnRole(role ?? "Staff"));
                        await UpdateUserTokenAsync(authenticated_UserId, GenToken, expiration);
                    }
                }
            }

            return GenToken;
        }


        public async Task<int> GetHoursBasedOnRole(string role) 
        {

            switch (role)
            {
                case "Doctor": return 12;
                case "Nurse": return 8;
                case "Receptionist": return 8;
                case "Admin": return 24;
                case "Staff": return 8;
                default: return 8;
            }

        }

        public async Task<string?> GetRoleByUserId(int userId)
        {
            string? role = null;
            using (var connection = _dbManager.GetConnection())
            using (var command = new MySqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = "SELECT role FROM users WHERE user_id = @UserId";
                command.Parameters.AddWithValue("@UserId", userId);
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        role = reader.GetString(0);
                    }
                }
            }
            return role;
        }

        public async Task<UserModel?> GetUserByUserIdAsync(int userId)
        {
            UserModel? loggedInUser = null;
            using (MySqlConnection connection = _dbManager.GetConnection())
            using (MySqlCommand command = new MySqlCommand()) { 
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = "SELECT user_id, username, email, role FROM users WHERE user_id = @UserId";
                command.Parameters.AddWithValue("@UserId", userId);

                using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        loggedInUser = new UserModel
                        {
                            UserId = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            Email = reader.GetString(2),
                            UserRole = (Role)Enum.Parse(typeof(Role), reader.GetString(3))
                        };
                    }
                }
            }
            return loggedInUser;
        }


        public async Task UpdateUserTokenAsync(int? userId, string? token, DateTime? expiration)
        {
            using (MySqlConnection connection = _dbManager.GetConnection())
            using (MySqlCommand command = new MySqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = "UPDATE users SET session_token = @Token, token_expiration = @Expiration WHERE user_id = @UserId";
                command.Parameters.AddWithValue("@Token", token);
                command.Parameters.AddWithValue("@Expiration", expiration);
                command.Parameters.AddWithValue("@UserId", userId);
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<bool> IsAccountAdminAsync(int userId)
        {
            bool isAdmin = false;

            using (var connection = _dbManager.GetConnection())
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT role FROM users WHERE user_id = @UserId";
                command.Parameters.AddWithValue("@UserId", userId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isAdmin = reader.GetString(0) == "Admin";
                    }
                }
            }
            return isAdmin;
        }

        //public Task StoreUserToken(int userId, string token)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> ValidateTokenAsync(string token)
        //{
        //    bool isValid = false;
        //    string? sessionToken = null;
        //    using (var connection = _dbManager.GetConnection())
        //    using (var command = new MySqlCommand())
        //    {
        //        connection.Open();
        //        command.Connection = connection;
        //        command.CommandText = "SELECT  FROM users WHERE session_token = @Token";
        //        command.Parameters.AddWithValue("@Token", token);
        //        using (var reader = command.ExecuteReader())
        //        {
        //            isValid = reader.Read();
        //        }
        //    }
        //}

        public async Task<UserModel?> GetUserByTokenAsync(string token)
        {
            UserModel? loggedInUser = null;
            using (var connection = _dbManager.GetConnection())
            using (var command = new MySqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = "SELECT user_id, username, email, role FROM users WHERE session_token = @SessionToken";
                command.Parameters.AddWithValue("@SessionToken", token);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        loggedInUser = new UserModel
                        {
                            UserId = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            Email = reader.GetString(2),
                            UserRole = (Role)Enum.Parse(typeof(Role), reader.GetString(3))
                        };
                    }
                }
            }
            return loggedInUser;
        }
        public string GenerateToken()
        {
            return Guid.NewGuid().ToString(); 
        }

        public async Task<bool> ClearUserToken(string token)
        {
            bool isTokenCleared = false;
            using (var connection = _dbManager.GetConnection())
            using (var command = new MySqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = "UPDATE users SET session_token = NULL WHERE session_token = @Token";
                command.Parameters.AddWithValue("@Token", token);
                isTokenCleared = await command.ExecuteNonQueryAsync() > 0;
            }

            return isTokenCleared;
        }


        //public bool ValidatePassword(string enteredPassword, string storedHashedPassword)
        //{
        //    throw new NotImplementedException();
        //}

        //public string HashPassword(string password)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> IsEmailTakenAsync(string email)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> IsUsernameTakenAsync(string usernameOrEmail)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> IsAccountStaffAsync(int userId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> IsAccountDoctor(int userId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> IsAccountNurse(int userId)
        //{
        //    throw new NotImplementedException();
        //}
        //public Task<bool> IsAccountReceptionist(int userId)
        //{
        //    throw new NotImplementedException();
        //}

    }
}

using hrms_query.Models;
using hrms_query.Database;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using hrms_query.Enums;

namespace hrms_query.Repositories
{
    public class RegisterQuery : IRegisterRepository
    {
        private readonly IDbManager _dbManager;

        public RegisterQuery(IDbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public async Task<bool> RegisterUserAsync(UserModel user, PersonModel person, string licenseNo, string specialization = null)
        {
            using (MySqlConnection connection =  _dbManager.GetConnection())
            {
                await connection.OpenAsync();
                using (MySqlTransaction transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        // Insert into Users table
                        int userId = await InsertUserAsync(user, transaction);

                        Console.WriteLine($"Inserted User with ID: {userId}"); // Debugging line

                        if (!await IsUserExistsAsync(userId, connection, transaction))
                        {
                            throw new Exception("User ID does not exist in the users table.");
                        }

                        await InsertRoleSpecificDataAsync(user, person, licenseNo, specialization, userId, transaction);
                        await transaction.CommitAsync();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        Console.WriteLine($"Error: {ex.Message}"); // Log the error
                        return false;
                    }
                }
            }
        }

        private async Task<bool> IsUserExistsAsync(int userId, MySqlConnection connection, MySqlTransaction transaction)
        {
            string checkUserQuery = "SELECT COUNT(*) FROM users WHERE user_id = @UserId";
            using (var checkCommand = new MySqlCommand(checkUserQuery, connection, transaction))
            {
                checkCommand.Parameters.AddWithValue("@UserId", userId);
                int count = Convert.ToInt32(await checkCommand.ExecuteScalarAsync());
                return count > 0;
            }
        }

        private async Task InsertRoleSpecificDataAsync(UserModel user, PersonModel person, string licenseNo, string specialization, int userId, MySqlTransaction transaction)
        {
            switch (user.UserRole)
            {
                case Role.Doctor:
                    var doctor = new DoctorModel
                    {
                        UserId = userId,
                        FirstName = person.FirstName,
                        LastName = person.LastName,
                        MiddleName = person.MiddleName,
                        ContactNumber = person.ContactNumber,
                        Email = person.Email,
                        Gender = person.Gender,
                        LicenseNo = licenseNo,
                        Specialization = specialization
                    };
                    await InsertDoctorAsync(doctor, transaction);
                    break;

                case Role.Nurse:
                    var nurse = new NurseModel
                    {
                        UserId = userId,
                        FirstName = person.FirstName,
                        LastName = person.LastName,
                        MiddleName = person.MiddleName,
                        ContactNumber = person.ContactNumber,
                        Email = person.Email,
                        Gender = person.Gender,
                        LicenseNo = licenseNo
                    };
                    await InsertNurseAsync(nurse, transaction);
                    break;

                case Role.Receptionist:
                    var receptionist = new ReceptionistModel
                    {
                        UserId = userId,
                        FirstName = person.FirstName,
                        LastName = person.LastName,
                        MiddleName = person.MiddleName,
                        ContactNumber = person.ContactNumber,
                        Email = person.Email,
                        Gender = person.Gender
                    };
                    await InsertReceptionistAsync(receptionist, transaction);
                    break;
            }
        }

        public async Task<int> InsertUserAsync(UserModel user, MySqlTransaction transaction)
        {
            string query = "INSERT INTO users (username, password, email, role) VALUES (@Username, @Password, @Email, @Role)";
            using (var command = new MySqlCommand(query, transaction.Connection, transaction))
            {
                command.Parameters.AddWithValue("@Username", user.UserName);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Role", user.UserRole.ToString());

                await command.ExecuteNonQueryAsync();
            }

            string getUserIdQuery = "SELECT LAST_INSERT_ID()";
            using (var getIdCommand = new MySqlCommand(getUserIdQuery, transaction.Connection, transaction))
            {
                int userId = Convert.ToInt32(await getIdCommand.ExecuteScalarAsync());
                return userId;
            }
        }

        public async Task<bool> InsertDoctorAsync(DoctorModel doctor, MySqlTransaction transaction)
        {
            string query = "INSERT INTO Doctors (user_id, first_name, last_name, middle_name, contact_number, email, gender, licenseNo, specialization) " +
                           "VALUES (@UserId, @FirstName, @LastName, @MiddleName, @ContactNumber, @Email, @Gender, @LicenseNo, @Specialization)";
            using (var command = new MySqlCommand(query, transaction.Connection, transaction))
            {
                command.Parameters.AddWithValue("@UserId", doctor.UserId);
                command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                command.Parameters.AddWithValue("@LastName", doctor.LastName);
                command.Parameters.AddWithValue("@MiddleName", doctor.MiddleName);
                command.Parameters.AddWithValue("@ContactNumber", doctor.ContactNumber);
                command.Parameters.AddWithValue("@Email", doctor.Email);
                command.Parameters.AddWithValue("@Gender", doctor.Gender.ToString());
                command.Parameters.AddWithValue("@LicenseNo", doctor.LicenseNo);
                command.Parameters.AddWithValue("@Specialization", doctor.Specialization);

                return await command.ExecuteNonQueryAsync() > 0;
            }
        }

        public async Task<bool> InsertNurseAsync(NurseModel nurse, MySqlTransaction transaction)
        {
            string query = "INSERT INTO Nurses (user_id, first_name, last_name, middle_name, contact_number, email, gender, licenseNo) " +
                           "VALUES (@UserId, @FirstName, @LastName, @MiddleName, @ContactNumber, @Email, @Gender, @LicenseNo)";
            using (var command = new MySqlCommand(query, transaction.Connection, transaction))
            {
                command.Parameters.AddWithValue("@UserId", nurse.UserId);
                command.Parameters.AddWithValue("@FirstName", nurse.FirstName);
                command.Parameters.AddWithValue("@LastName", nurse.LastName);
                command.Parameters.AddWithValue("@MiddleName", nurse.MiddleName);
                command.Parameters.AddWithValue("@ContactNumber", nurse.ContactNumber);
                command.Parameters.AddWithValue("@Email", nurse.Email);
                command.Parameters.AddWithValue("@Gender", nurse.Gender.ToString());
                command.Parameters.AddWithValue("@LicenseNo", nurse.LicenseNo);

                return await command.ExecuteNonQueryAsync() > 0;
            }
        }

        public async Task<bool> InsertReceptionistAsync(ReceptionistModel receptionist, MySqlTransaction transaction)
        {
            string query = "INSERT INTO Receptionist (user_id, first_name, last_name, middle_name, contact_number, email, gender) " +
                           "VALUES (@UserId, @FirstName, @LastName, @MiddleName, @ContactNumber, @Email, @Gender)";
            using (var command = new MySqlCommand(query, transaction.Connection, transaction))
            {
                command.Parameters.AddWithValue("@UserId", receptionist.UserId);
                command.Parameters.AddWithValue("@FirstName", receptionist.FirstName);
                command.Parameters.AddWithValue("@LastName", receptionist.LastName);
                command.Parameters.AddWithValue("@MiddleName", receptionist.MiddleName);
                command.Parameters.AddWithValue("@ContactNumber", receptionist.ContactNumber);
                command.Parameters.AddWithValue("@Email", receptionist.Email);
                command.Parameters.AddWithValue("@Gender", receptionist.Gender.ToString());

                return await command.ExecuteNonQueryAsync() > 0;
            }
        }

        public async Task<bool> IsEmailTakenAsync(string email)
        {
            using (var connection = _dbManager.GetConnection())
            using (var command = new MySqlCommand("SELECT * FROM users WHERE email = @Email", connection))
            {
                await connection.OpenAsync();
                command.Parameters.AddWithValue("@Email", email);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    return await reader.ReadAsync();
                }
            }
        }

        public async Task<bool> IsUsernameTakenAsync(string username)
        {
            using (var connection =  _dbManager.GetConnection())
            using (var command = new MySqlCommand("SELECT * FROM users WHERE username = @Username", connection))
            {
                await connection.OpenAsync();
                command.Parameters.AddWithValue("@Username", username);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    return await reader.ReadAsync();
                }
            }
        }

        public Task<bool> IsAccountAdminAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsAccountStaffAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAdminAsync(AdminModel admin, MySqlTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}

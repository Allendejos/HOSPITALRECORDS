using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Compiler;
using hrms_query.Database;
using hrms_query.Models;
using hrms_query.Enums;
using MySql.Data.MySqlClient;


using static hrms_query.Models.Enums.enumList;
using System.Data;
using Mysqlx.Cursor;

namespace hrms_query.Repositories
{
    public class PatientRecordsQuery : IPatientRecordsRepository
    {

        private readonly IDbManager _dbManager;

        public PatientRecordsQuery(IDbManager dbManager)
        {
            _dbManager = dbManager;
        }



        public List<PatientModel> GetPatientList()
        {
            throw new NotImplementedException();
        }
        public Task<bool> AddMedicalRecords(MedicalRecordsModel medicalRecords)
        {
            throw new NotImplementedException();
        }

 

        public async Task<MedicalRecordsModel> GetMedicalRecords(int patientId)
        {

           throw new NotImplementedException();
        }

        public async Task<PatientModel> GetPatientById(int patientId)
        {
            PatientModel patient = null;

            try
            {
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();

                    string query = "SELECT * FROM patients WHERE patient_id = @patientId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);

                        using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync()) // Check if there is data to read
                            {
                                patient = new PatientModel()
                                {
                                    PatientId = reader.GetInt32("patient_id"),
                                    PatientCode = reader.GetString("patient_code"),
                                    FirstName = reader.GetString("first_name"),
                                    MiddleName = reader.IsDBNull(reader.GetOrdinal("middle_name")) ? null : reader.GetString("middle_name"),
                                    LastName = reader.GetString("last_name"),
                                    DateOfBirth = reader.GetDateTime("date_of_birth"),
                                    Gender = reader.GetString("gender"),
                                    PhoneNumber = reader.IsDBNull(reader.GetOrdinal("phone_number")) ? null : reader.GetString("phone_number"),
                                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                                    Address = reader.IsDBNull(reader.GetOrdinal("address")) ? null : reader.GetString("address"),
                                    Occupation = reader.IsDBNull(reader.GetOrdinal("occupation")) ? null : reader.GetString("occupation"),
                                    Religion = reader.GetString("religion"),
                                    Nationality = reader.GetString("nationality"),
                                    MaritalStatus = reader.GetString("marital_status"),
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return patient;
        }

        public async Task<int> AddPatientRecords(PatientModel patient)
        {
            try
            {
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();
                    string GenPatientCode = await GeneratePatientCodeAsync(connection);

                    string query = "INSERT INTO patients " +
                                   "(patient_code, " +
                                   "first_name, " +
                                   "middle_name, " +
                                   "last_name, " +
                                   "gender, " +
                                   "address, " +
                                   "phone_number, " +
                                   "email, " +
                                   "religion, " +
                                   "occupation, " +
                                   "nationality, " +
                                   "marital_status, " +
                                   "date_of_birth) " +
                                   "VALUES " +
                                   "(@patientCode, " +
                                   "@firstName, " +
                                   "@middleName, " +
                                   "@lastName, " +
                                   "@gender, " +
                                   "@address, " +
                                   "@phoneNumber, " +
                                   "@email, " +
                                   "@religion, " +
                                   "@occupation, " +
                                   "@nationality, " +
                                   "@maritalStatus, " +
                                   "@dateOfBirth); " +
                                   "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@patientCode", GenPatientCode);
                        command.Parameters.AddWithValue("@firstName", patient.FirstName);
                        command.Parameters.AddWithValue("@middleName", patient.MiddleName);
                        command.Parameters.AddWithValue("@lastName", patient.LastName);
                        command.Parameters.AddWithValue("@gender", patient.Gender);
                        command.Parameters.AddWithValue("@address", patient.Address); 
                        command.Parameters.AddWithValue("@phoneNumber", patient.PhoneNumber);
                        command.Parameters.AddWithValue("@email", patient.Email);
                        command.Parameters.AddWithValue("@religion", patient.Religion);
                        command.Parameters.AddWithValue("@occupation", patient.Occupation); 
                        command.Parameters.AddWithValue("@nationality", patient.Nationality);
                        command.Parameters.AddWithValue("@maritalStatus", patient.MaritalStatus);
                        command.Parameters.AddWithValue("@dateOfBirth", patient.DateOfBirth); 

                        patient.PatientId = Convert.ToInt32(await command.ExecuteScalarAsync());


                        return patient.PatientId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add patient record: " + ex.Message);
            }
        }

        public async Task<string> GeneratePatientCodeAsync(MySqlConnection connection)
        {
            // Query to get the maximum patient_code
            string query = "SELECT MAX(patient_code) FROM patients;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Execute the query
                var result = await command.ExecuteScalarAsync();

                // If no patients exist, start with P001
                if (result == null || result == DBNull.Value)
                {
                    return "P001";
                }

                // Extract the numeric part of the patient_code
                string maxPatientCode = result.ToString();
                if (int.TryParse(maxPatientCode.Substring(1), out int numericPart))
                {
                    // Increment the numeric part and format it
                    return $"P{(numericPart + 1):D3}"; // Ensures 3-digit format (e.g., P001, P002)
                }
                else
                {
                    throw new Exception("Invalid patient_code format in the database.");
                }
            }
        }
        public async Task<bool> UpdatePatientRecords(PatientModel updatedPatient, int patientId)
        {
            try
            {
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();

                    string query = @"
                UPDATE patients
                SET 
                    first_name = @firstName,
                    middle_name = @middleName,
                    last_name = @lastName,
                    gender = @gender,
                    phone_number = @phoneNumber,
                    email = @email,
                    address = @address,
                    religion = @religion,
                    occupation = @occupation,
                    nationality = @nationality,
                    marital_status = @maritalStatus,
                    date_of_birth = @dateOfBirth
                WHERE patient_id = @patientId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);
                        command.Parameters.AddWithValue("@firstName", updatedPatient.FirstName);
                        command.Parameters.AddWithValue("@middleName", updatedPatient.MiddleName ?? string.Empty);
                        command.Parameters.AddWithValue("@lastName", updatedPatient.LastName);
                        command.Parameters.AddWithValue("@gender", updatedPatient.Gender);
                        command.Parameters.AddWithValue("@phoneNumber", updatedPatient.PhoneNumber ?? string.Empty);
                        command.Parameters.AddWithValue("@email", updatedPatient.Email ?? string.Empty);
                        command.Parameters.AddWithValue("@address", updatedPatient.Address ?? string.Empty);
                        command.Parameters.AddWithValue("@religion", updatedPatient.Religion);
                        command.Parameters.AddWithValue("@occupation", updatedPatient.Occupation ?? string.Empty);
                        command.Parameters.AddWithValue("@nationality", updatedPatient.Nationality);
                        command.Parameters.AddWithValue("@maritalStatus", updatedPatient.MaritalStatus);
                        command.Parameters.AddWithValue("@dateOfBirth", updatedPatient.DateOfBirth);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected == 0)
                        {
                            throw new Exception("No rows were updated.");
                        }
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeletePatientRecords(int patientId)
        {
            try
            {
                //GuardianModel newGuardian = new GuardianModel();
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();

                    string query = "DELETE FROM patients" +
                        "WHERE patient_id = @patientId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);
                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected == 0) { throw new Exception(); }
                        return rowsAffected > 0;
                    }


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<PatientModel>> GetPatientListAsync()
        {
            List<PatientModel> patientList = new List<PatientModel>();

            try
            {
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();
                    string query = "SELECT * FROM patients";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                PatientModel patient = new PatientModel
                                {
                                    PatientId = reader.GetInt32("patient_id"),
                                    PatientCode = reader.GetString("patient_code"),
                                    FirstName = reader.GetString("first_name"),
                                    MiddleName = reader.IsDBNull("middle_name") ? null : reader.GetString("middle_name"),
                                    LastName = reader.GetString("last_name"),
                                    DateOfBirth = reader.GetDateTime("date_of_birth"),
                                    Gender = reader.GetString("gender"),
                                    PhoneNumber = reader.GetString("phone_number"),
                                    Email = reader.GetString("email"),
                                    Address = reader.GetString("address"),
                                    Religion = reader.GetString("religion"),
                                    Occupation = reader.IsDBNull("occupation") ? null : reader.GetString("occupation"),
                                    Nationality = reader.GetString("nationality"),
                                    MaritalStatus = reader.GetString("marital_status"),
                                };

                                try
                                {
                                    patient.Guardian = await GetGuardianAsync(patient.PatientId);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"No guardian found for Patient ID {patient.PatientId}: {ex.Message}");
                                    patient.Guardian = null; 
                                }

                                patientList.Add(patient);
                            }
                        }
                    }

                    if (patientList.Count == 0)
                    {
                        throw new Exception("No patients found in the database");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return patientList;
        }

        public async Task<bool> CheckHasGuardianAsync(int patientId)
        {
            try
            {
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();
                    string query = "SELECT COUNT(*) FROM guardians WHERE patient_id = @patientId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);
                        int count = Convert.ToInt32(await command.ExecuteScalarAsync());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<GuardianModel> GetGuardianAsync(int patientId)
        {
            GuardianModel patientGuardian = null;

            try
            {
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();

                    string query = "SELECT * FROM guardians WHERE patient_id = @patientId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);
                        using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync()) // Check if there is a guardian
                            {
                                patientGuardian = new GuardianModel()
                                {
                                    G_FirstName = reader.GetString("first_name"),
                                    G_MiddleName = reader.IsDBNull("middle_name") ? "N/A" : reader.GetString("middle_name"),
                                    G_LastName = reader.GetString("last_name"),
                                    G_Gender =  reader.GetString("gender"),
                                    G_PhoneNumber = reader.IsDBNull("phone_number") ? "N/A" : reader.GetString("phone_number"),
                                    G_Email = reader.IsDBNull("email") ? "N/A" : reader.GetString("email"),
                                    G_Relationship = reader.IsDBNull("relationship") ? "N/A" : reader.GetString("relationship"),
                                    Patient = await GetPatientById(patientId) // Assign the PatientModel
                                };
                            }
                            else
                            {
                                throw new Exception("No guardian found for the patient");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return patientGuardian;
        }
        public async Task<bool> UpdateGuardianInfoAsync(GuardianModel updatedGuardianData, int patientId)
        {
            
            try
            {
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();

                    string query = @"
                    UPDATE guardians 
                    SET 
                        first_name = @firstName,
                        middle_name = @middleName,
                        last_name = @lastName,
                        gender = @gender,
                        phone_number = @phoneNumber,
                        email = @email,
                        relationship = @relationship
                    WHERE patient_id = @patientId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);
                        command.Parameters.AddWithValue("@firstName", updatedGuardianData.G_FirstName);
                        command.Parameters.AddWithValue("@middleName", updatedGuardianData.G_MiddleName);
                        command.Parameters.AddWithValue("@lastName", updatedGuardianData.G_LastName);
                        command.Parameters.AddWithValue("@gender", updatedGuardianData.G_Gender);
                        command.Parameters.AddWithValue("@phoneNumber", updatedGuardianData.G_PhoneNumber);
                        command.Parameters.AddWithValue("@email", updatedGuardianData.G_Email);
                        command.Parameters.AddWithValue("@relationship", updatedGuardianData.G_Relationship);

                        int rowsAffected = await command.ExecuteNonQueryAsync();
                        
                        if(rowsAffected == 0) { throw new Exception("Failed To Update Guardian Info"); }
                        return rowsAffected > 0;
                    }


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CreateGuardianInfoAsync(GuardianModel newGuardian, int patientId)
        {
            try
            {
                //GuardianModel newGuardian = new GuardianModel();
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();

                    string query = "INSERT INTO guardians" +
                        "(patient_id, first_name, middle_name, last_name, gender, relationship, phone_number, email)" +
                        "VALUES(@patientId, @firstName, @middleName, @lastName, @gender, @relationship, @phoneNumber, @email)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);
                        command.Parameters.AddWithValue("@firstName", newGuardian.G_FirstName);
                        command.Parameters.AddWithValue("@middleName", newGuardian.G_MiddleName);
                        command.Parameters.AddWithValue("@lastName", newGuardian.G_LastName);
                        command.Parameters.AddWithValue("@gender", newGuardian.G_Gender);
                        command.Parameters.AddWithValue("@phoneNumber", newGuardian.G_PhoneNumber);
                        command.Parameters.AddWithValue("@email", newGuardian.G_Email);
                        command.Parameters.AddWithValue("@relationship", newGuardian.G_Relationship);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected == 0) { throw new Exception(); }
                        return rowsAffected > 0;
                    }


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteGuardianInfoAsync(int patientId)
        {
            try
            {
                //GuardianModel newGuardian = new GuardianModel();
                using (MySqlConnection connection = _dbManager.GetConnection())
                {
                    await connection.OpenAsync();

                    string query = "DELETE FROM guardians" +
                        "WHERE patient_id = @patientId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);
                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected == 0) { throw new Exception(); }
                        return rowsAffected > 0;
                    }


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

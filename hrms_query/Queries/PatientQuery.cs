using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using hrms_query.Models;
using hrms_query.Enums;
using hrms_query.Database;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace hrms_query.Repositories
{
    public class PatientQuery : IPatientRepository
    {
        private const int V = 10;
        private readonly IDbManager _dbManager;
        public PatientQuery(IDbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public void Add(PatientModel patient)
        {
            throw new NotImplementedException();
        }

        public void Delete(int patient_id)
        {
            throw new NotImplementedException();
        }
        public void Update(PatientModel patient)
        {

        }

        public IEnumerable<PatientModel> GetAllPatients()
        {
            var patientList = new List<PatientModel>();
            using (var connection = _dbManager.GetConnection())
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM patients order by patient_id ASC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var patient = new PatientModel
                        {
                            PatientId = (int)reader[0],
                            PatientCode = reader[1].ToString(),
                            FirstName = reader[2].ToString(),
                            MiddleName = reader[3]?.ToString(),
                            LastName = reader[4].ToString(),
                            DateOfBirth = (DateTime)reader[5],
                            Gender = reader[6].ToString(),
                            PhoneNumber = reader[7].ToString(),
                            Email = reader[8].ToString(),
                            Address = reader[9].ToString(),
                            Religion = reader[10].ToString(),
                            Occupation = reader[11]?.ToString(),
                            //Nationality = reader[12].ToString(),
                            //MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), reader[13].ToString()),


                        };
                        patientList.Add(patient);
                    }

                }


            }
            return patientList;
        }


        public IEnumerable<PatientModel> GetPatientByValue(string SearchValue)
        {
            var patientList = new List<PatientModel>();
            string searchInput = SearchValue?.Trim() ?? string.Empty;

            int id;
            bool isNumeric = int.TryParse(SearchValue, out id);

            using (var connection = _dbManager.GetConnection())
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"SELECT * FROM patients 
                                            WHERE 
                                                (@id IS NOT NULL AND patient_id = @id) 
                                                OR (@patCode IS NOT NULL AND patient_code LIKE CONCAT(@patCode, '%'))
                                                OR (@firstName IS NOT NULL AND first_name LIKE CONCAT(@firstName, '%'))
                                                OR (@middleName IS NOT NULL AND middle_name LIKE CONCAT(@middleName, '%'))
                                                OR (@lastName IS NOT NULL AND last_name LIKE CONCAT(@lastName, '%'))
                                            ORDER BY patient_id ASC";

                command.Parameters.AddWithValue("@id", isNumeric ? id : DBNull.Value);
                command.Parameters.AddWithValue("@patCode", string.IsNullOrEmpty(searchInput) ? DBNull.Value : searchInput);
                command.Parameters.AddWithValue("@firstName", string.IsNullOrEmpty(searchInput) ? DBNull.Value : searchInput);
                command.Parameters.AddWithValue("@middleName", string.IsNullOrEmpty(searchInput) ? DBNull.Value : searchInput);
                command.Parameters.AddWithValue("@lastName", string.IsNullOrEmpty(searchInput) ? DBNull.Value : searchInput);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var patient = new PatientModel
                        {
                            PatientId = (int)reader[0],
                            PatientCode = reader[1].ToString(),
                            FirstName = reader[2].ToString(),
                            MiddleName = reader[3]?.ToString(),
                            LastName = reader[4].ToString(),
                            DateOfBirth = (DateTime)reader[5],
                            Gender = reader[6].ToString(),
                            PhoneNumber = reader[7].ToString(),
                            Email = reader[8].ToString(),
                            Address = reader[9].ToString(),
                            Religion = reader[10].ToString(),
                            Occupation = reader[11]?.ToString(),
                            //Nationality = (Nationality)Enum.Parse(typeof(Nationality), reader[12].ToString()),
                            //MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), reader[13].ToString()),
                        };
                        patientList.Add(patient);
                    }
                }
            }
            return patientList;
        }

 


    }
}

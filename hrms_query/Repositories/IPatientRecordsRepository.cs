using hrms_query.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Repositories
{
    public interface IPatientRecordsRepository
    {
        List<PatientModel> GetPatientList();
        Task<List<PatientModel>> GetPatientListAsync();

        // Crud OPERATION for Patient Records
        Task<PatientModel> GetPatientById(int patientId);

        Task<int> AddPatientRecords(PatientModel patient);

        Task<bool> UpdatePatientRecords(PatientModel patient, int patientId);

        Task<bool> DeletePatientRecords(int patientId);
        Task<string> GeneratePatientCodeAsync(MySqlConnection connection);


        // Crud OPERATION for Medical Records

        Task<MedicalRecordsModel> GetMedicalRecords(int patientId);
        Task<bool> AddMedicalRecords(MedicalRecordsModel medicalRecords);


        // Crud OPERATION for Guardian Records

        Task<GuardianModel> GetGuardianAsync(int patientId);
        Task<bool> CheckHasGuardianAsync(int patientId);
        Task<bool> UpdateGuardianInfoAsync(GuardianModel updatedGuardianData, int patientId);
        Task<bool> CreateGuardianInfoAsync(GuardianModel newGuardian, int patientId);
        Task<bool> DeleteGuardianInfoAsync(int patientId);



    }
}

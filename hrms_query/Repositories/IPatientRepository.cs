using hrms_query.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_query.Repositories
{
    public interface IPatientRepository
    {
        void Add(PatientModel patient);
        void Update(PatientModel patient);
        void Delete(int patient_id);

        IEnumerable<PatientModel> GetAllPatients();
        IEnumerable<PatientModel> GetPatientByValue(string SearchValue);

    }
}

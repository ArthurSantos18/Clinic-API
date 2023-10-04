using ClinicAPI.Models.DTOs;
using ClinicAPI.Models.Entities;

namespace ClinicAPI.Repository.Interface
{
    public interface IPatientRepository : IBaseRepository
    {
        Task<IEnumerable<PatientDto>> GetAllPatientsAsync();
        Task<Patient> GetByIdAsync(int id);
    }
}

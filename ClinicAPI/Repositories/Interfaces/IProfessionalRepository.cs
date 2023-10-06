using ClinicAPI.Models.Dto;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repository.Interface;

namespace ClinicAPI.Repositories.Interfaces
{
    public interface IProfessionalRepository : IBaseRepository
    {
        Task<IEnumerable<ProfessionalDto>> GetAllProfessionalsAsync();
        Task<Professional> GetByIdAsync(int id);
    }
}

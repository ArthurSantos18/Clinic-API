using ClinicAPI.Models.Dto;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repository.Interface;

namespace ClinicAPI.Repositories.Interfaces
{
    public interface ISpecialtyRepository : IBaseRepository
    {
        Task<IEnumerable<SpecialtyDto>> GetAllSpecialitiesAsync();
        Task<Specialty> GetByIdAsync(int id);
    }
}

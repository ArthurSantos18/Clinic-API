using ClinicAPI.Data;
using ClinicAPI.Models.Dto;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repositories.Interfaces;
using ClinicAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repositories
{
    public class SpecialtyRepository : BaseRepository, ISpecialtyRepository
    {
        private readonly ClinicContext _context;
        public SpecialtyRepository(ClinicContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SpecialtyDto>> GetAllSpecialitiesAsync()
        {
            return await _context.Specialties
                .Select(x => new SpecialtyDto { Id = x.Id, Name = x.Name, Active = x.Active })
                .ToListAsync();
        }

        public async Task<Specialty> GetByIdAsync(int id)
        {
            return await _context.Specialties
                .Include(x => x.Professionals)
                .Include(x => x.Appointments)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

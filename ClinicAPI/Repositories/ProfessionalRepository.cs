using ClinicAPI.Data;
using ClinicAPI.Models.Dto;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repositories.Interfaces;
using ClinicAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repositories
{
    public class ProfessionalRepository : BaseRepository, IProfessionalRepository
    {
        private readonly ClinicContext _context;

        public ProfessionalRepository(ClinicContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProfessionalDto>> GetAllProfessionalsAsync()
        {
            return await _context.Professionals
                .Select(s => new ProfessionalDto { Id = s.Id, Name = s.Name, Active = s.Active })
                .ToListAsync();
        }

        public async Task<Professional> GetByIdAsync(int id)
        {
            return await _context.Professionals
                .Include(x => x.Appointments)
                .Include(x => x.Specialties)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}


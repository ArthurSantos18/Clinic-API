using ClinicAPI.Data;
using ClinicAPI.Models.DTOs;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repository
{
    public class PatientRepository : BaseRepository, IPatientRepository
    {
        private readonly ClinicContext _context;
        
        public PatientRepository(ClinicContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PatientDto>> GetAllPatientsAsync()
        {
            return await _context.Patients
                .Select(x => new PatientDto { Id = x.Id, Name = x.Name })
                .ToListAsync();
            
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            return await _context.Patients
                .Include(x => x.Appointments)
                .ThenInclude(x => x.Specialty)
                .ThenInclude(x => x.Professionals)
                .FirstOrDefaultAsync(p => p.Id == id);
            
        }
    }
}

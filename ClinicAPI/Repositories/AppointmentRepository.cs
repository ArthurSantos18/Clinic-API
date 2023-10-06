using ClinicAPI.Data;
using ClinicAPI.Models.DTOs;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repositories.Interfaces;
using ClinicAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Repositories
{
    public class AppointmentRepository : BaseRepository, IAppointmentRepository
    {
        private readonly ClinicContext _context;
        public AppointmentRepository(ClinicContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AppointmentDto>> GetAllAppointmentsAsync()
        {
            return await _context.Appointments.Select
                (x => new AppointmentDto
                {
                    Id = x.Id,
                    Price = x.Price,
                    Time = x.Time,
                    Status = x.Status,
                    Pacient = x.Patient.Name,
                    Specialty = x.Specialty.Name,
                    Professional = x.Professional.Name
                }
                ).ToListAsync();
        }

        public async Task<Appointment> GetByIdAsync(int id)
        {
            return await _context.Appointments
                .Include(x => x.Patient)
                .Include(x => x.Professional)
                .Include(x => x.Specialty)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

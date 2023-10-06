using ClinicAPI.Models.DTOs;
using ClinicAPI.Models.Entities;
using ClinicAPI.Repository.Interface;

namespace ClinicAPI.Repositories.Interfaces
{
    public interface IAppointmentRepository : IBaseRepository
    {
        Task<IEnumerable<AppointmentDto>> GetAllAppointmentsAsync();
        Task<Appointment> GetByIdAsync(int id);
    }
}

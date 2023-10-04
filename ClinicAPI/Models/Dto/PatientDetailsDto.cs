using ClinicAPI.Models.Entities;

namespace ClinicAPI.Models.DTOs
{
    public class PatientDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<AppointmentDto> Appointments { get; set; }
    }
}

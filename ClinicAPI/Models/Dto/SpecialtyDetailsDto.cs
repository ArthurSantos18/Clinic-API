using ClinicAPI.Models.DTOs;
using ClinicAPI.Models.Entities;

namespace ClinicAPI.Models.Dto
{
    public class SpecialtyDetailsDto
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public string[] Professionals { get; set; }
        public List<AppointmentDto> Appointments { get; set; } = new List<AppointmentDto>();
    }
}

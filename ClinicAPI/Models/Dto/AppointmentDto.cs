using ClinicAPI.Models.Entities;

namespace ClinicAPI.Models.DTOs
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int Status { get; set; }
        public double Price { get; set; }
        public string Specialty { get; set; }
        public string Professional { get; set; }
    }
}

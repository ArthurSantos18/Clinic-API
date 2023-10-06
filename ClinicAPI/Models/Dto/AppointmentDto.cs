using ClinicAPI.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models.DTOs
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int Status { get; set; }
        public decimal Price { get; set; }
        public string Pacient { get; set; }
        public string Specialty { get; set; }
        public string Professional { get; set; }
    }
}

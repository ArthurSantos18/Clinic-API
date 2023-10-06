using ClinicAPI.Models.DTOs;

namespace ClinicAPI.Models.Dto
{
    public class AppointmentDetailsDto
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int Status { get; set; }
        public decimal Price { get; set; }
        public PatientDto Patient { get; set; }
        public SpecialtyDto Specialty { get; set; }
        public ProfessionalDto Professional { get; set; }
    }
}

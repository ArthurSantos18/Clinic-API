namespace ClinicAPI.Models.Dto
{
    public class AppointmentUpdateDto
    {
        public DateTime Time { get; set; }
        public int Status { get; set; }
        public decimal Price { get; set; }
        public int? PatientId { get; set; }
        public int? SpecialtyId { get; set; }
        public int? ProfessionalId { get; set; }
    }
}

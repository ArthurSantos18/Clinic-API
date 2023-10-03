namespace ClinicAPI.Models.Entities
{
    public class Appointment : Base
    {
        public DateTime Time { get; set; }
        public int Status { get; set; }
        public double Price { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
        public int ProfessionalId { get; set; }
        public Professional Professional { get; set; }
    }
}

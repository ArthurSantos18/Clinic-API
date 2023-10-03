namespace ClinicAPI.Models.Entities
{
    public class ProfessionalSpecialty
    {
        public int ProfessionalId { get; set; }
        public Professional Professional { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
    }
}

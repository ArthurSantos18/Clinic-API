namespace ClinicAPI.Models.Entities
{
    public class Professional : Base
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        public List<Specialty> Specialties { get; set; } = new List<Specialty>();
    }
}

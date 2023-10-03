namespace ClinicAPI.Models.Entities
{
    public class Specialty : Base
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public List <Professional> Professionals { get; set; } = new List<Professional>();
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}

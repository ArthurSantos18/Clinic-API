namespace ClinicAPI.Models.Entities
{
    public class Patient : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Cpf { get; set; }
        public List <Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}

namespace ClinicAPI.Models.Dto
{
    public class PatientUpdateDto
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Cpf { get; set; }
    }
}

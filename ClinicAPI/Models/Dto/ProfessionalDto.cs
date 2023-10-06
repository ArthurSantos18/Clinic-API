using ClinicAPI.Models.DTOs;
using ClinicAPI.Models.Entities;

namespace ClinicAPI.Models.Dto
{
    public class ProfessionalDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAPI.Models.Entities
{
    public class Scheduling
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Time { get; set; }
    }
}

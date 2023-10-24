using ClinicAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Data
{
    public class ClinicContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<ProfessionalSpecialty> ProfessionalSpecialties { get; set; }
        public ClinicContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.Seed();)

        }

    }
}

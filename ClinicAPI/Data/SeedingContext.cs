using ClinicAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Data
{
    public static class SeedingContext
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Patient p1 = new Patient { Id = 1, Name = "Eva", Email = "eva@gmail.com", Cpf = "12345678944", PhoneNumber = "12346578"};
            Patient p2 = new Patient { Id = 2, Name = "Rudolf", Email = "rudolf@gmail.com", Cpf = "12345678955", PhoneNumber = "87654321" };
            Patient p3 = new Patient { Id = 3, Name = "Maria", Email = "maria@gmail.com", Cpf = "12345678966", PhoneNumber = "87421345" };
            Patient p4 = new Patient { Id = 4, Name = "Kyrie", Email = "kyrie@gmail.com", Cpf = "12345678922", PhoneNumber = "12345678" };

            Professional pr1 = new Professional { Id = 1, Name = "Battler", Active = true };
            Professional pr2 = new Professional { Id = 2, Name = "Beatrice", Active = true };

            Specialty sp1 = new Specialty { Id = 1, Name = "Psicologia", Active = true };
            Specialty sp2 = new Specialty { Id = 2, Name = "Pediatria", Active = true };

            ProfessionalSpecialty ps1 = new ProfessionalSpecialty { ProfessionalId = 1, SpecialtyId = 1 };
            ProfessionalSpecialty ps2 = new ProfessionalSpecialty { ProfessionalId = 2, SpecialtyId = 1 };
            ProfessionalSpecialty ps3 = new ProfessionalSpecialty { ProfessionalId = 2, SpecialtyId = 2 };

            Appointment a1 = new Appointment
            {
                Id = 1,
                PatientId = 1,
                ProfessionalId = 1,
                SpecialtyId = 1,
                Status = 1,
                Time = DateTime.Now,
                Price = 30.50m
            };

            Appointment a2 = new Appointment
            {
                Id = 2,
                PatientId = 2,
                ProfessionalId = 1,
                SpecialtyId = 1,
                Status = 1,
                Time = DateTime.Now,
                Price = 40.90m
            };

            Appointment a3 = new Appointment
            {
                Id = 3,
                PatientId = 3,
                ProfessionalId = 2,
                SpecialtyId = 2,
                Status = 1,
                Time = DateTime.Now,
                Price = 60.00m
            };

            Appointment a4 = new Appointment
            {
                Id = 4,
                PatientId = 3,
                ProfessionalId = 2,
                SpecialtyId = 1,
                Status = 1,
                Time = DateTime.Now,
                Price = 25.45m
            };

            Appointment a5 = new Appointment
            {
                Id = 5,
                PatientId = 4,
                ProfessionalId = 2,
                SpecialtyId = 1,
                Status = 1,
                Time = DateTime.Now,
                Price = 70.20m
            };

            modelBuilder.Entity<Appointment>().HasData(a1, a2, a3, a4, a5);
            modelBuilder.Entity<Patient>().HasData(p1, p2, p3, p4);
            modelBuilder.Entity<Specialty>().HasData(sp1, sp2);
            modelBuilder.Entity<Professional>().HasData(pr1, pr2);
            modelBuilder.Entity<ProfessionalSpecialty>().HasData(ps1, ps2, ps3);
        }

    }
}

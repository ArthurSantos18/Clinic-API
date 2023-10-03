using ClinicAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicAPI.Map
{
    public class AppointmentMap : BaseMap<Appointment>
    {
        public AppointmentMap() : base("appointments")
        {

        }
        public override void Configure(EntityTypeBuilder<Appointment> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Status).HasColumnName("status").HasDefaultValue(1);
            builder.Property(x => x.Price).HasColumnName("price").HasPrecision(7, 2);
            builder.Property(x => x.Time).HasColumnName("date_time").IsRequired();

            builder.Property(x => x.PatientId).HasColumnName("id_patient").IsRequired();
            builder.HasOne(x => x.Patient).WithMany(x => x.Appointments).HasForeignKey(x => x.PatientId);

            builder.Property(x => x.ProfessionalId).HasColumnName("id_professional").IsRequired();
            builder.HasOne(x => x.Professional).WithMany(x => x.Appointments).HasForeignKey(x => x.ProfessionalId);

            builder.Property(x => x.SpecialtyId).HasColumnName("id_specialty").IsRequired();
            builder.HasOne(x => x.Specialty).WithMany(x => x.Appointments).HasForeignKey(x => x.SpecialtyId);
        }
    }
}

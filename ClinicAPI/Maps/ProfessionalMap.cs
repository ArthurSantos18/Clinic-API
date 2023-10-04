using ClinicAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicAPI.Map
{
    public class ProfessionalMap : BaseMap<Professional>
    {
        public ProfessionalMap() : base("professionals")
        {

        }
        public override void Configure(EntityTypeBuilder<Professional> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Active).HasColumnName("active");

            builder.HasMany(x => x.Specialties).WithMany(x => x.Professionals).UsingEntity<ProfessionalSpecialty>(
                x => x.HasOne(x => x.Specialty).WithMany().HasForeignKey(x => x.SpecialtyId),
                x => x.HasOne(x => x.Professional).WithMany().HasForeignKey(x => x.ProfessionalId),
                x =>
                {
                    x.ToTable("professionals_specialties");
                    x.HasKey(x => new { x.SpecialtyId, x.ProfessionalId });
                    x.Property(x => x.SpecialtyId).HasColumnName("id_specialty").IsRequired();
                    x.Property(x => x.ProfessionalId).HasColumnName("id_professional").IsRequired();
                }
                );
        }
    }
}

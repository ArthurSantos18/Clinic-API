using ClinicAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicAPI.Map
{
    public class SpecialtyMap : BaseMap<Specialty>
    {
        public SpecialtyMap() : base("specialties")
        {

        }

        public override void Configure(EntityTypeBuilder<Specialty> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name").IsRequired();
            builder.Property(x => x.Active).HasColumnName("active");
        }
    }
}

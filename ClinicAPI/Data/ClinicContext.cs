using ClinicAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Data
{
    public class ClinicContext : DbContext
    {
        DbSet<Scheduling> Schedulings { get; set; }

        public ClinicContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var schedulings = modelBuilder.Entity<Scheduling>();

            schedulings.ToTable("schedulings");
            schedulings.HasKey(s => s.Id);
            schedulings.Property(s => s.Id).HasColumnName("id").ValueGeneratedOnAdd();
            schedulings.Property(s => s.Name).HasColumnName("name").HasColumnType("varchar(100)").IsRequired();
            schedulings.Property(s => s.Age).HasColumnName("age").HasColumnType("int").IsRequired();
            schedulings.Property(s => s.Time).HasColumnName("time").HasColumnType("datetime").IsRequired();

        }

    }
}

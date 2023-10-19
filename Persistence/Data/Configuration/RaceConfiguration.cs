using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Race");

            builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

            builder.HasOne(p => p.Species)
            .WithMany(p => p.Races)
            .HasForeignKey(p => p.IdSpecieFk);

            

        }
    }
}
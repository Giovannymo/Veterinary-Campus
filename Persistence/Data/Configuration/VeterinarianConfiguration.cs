using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class VeterinarianConfiguration : IEntityTypeConfiguration<Veterinarian>
    {
        public void Configure(EntityTypeBuilder<Veterinarian> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Veterinarian");

            builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(255);

            builder.Property(p => p.Telephone)
            .IsRequired()
            .HasMaxLength(15);

            builder.Property(p => p.Specialization)
            .IsRequired()
            .HasMaxLength(100);
        }
    }
}
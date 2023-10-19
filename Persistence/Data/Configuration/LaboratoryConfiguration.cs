using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class LaboratoryConfiguration : IEntityTypeConfiguration<Laboratory>
    {
        public void Configure(EntityTypeBuilder<Laboratory> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Laboratory");

            builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(e => e.Address)
            .IsRequired()
            .HasMaxLength(255);

            builder.Property(e => e.Telephone)
            .IsRequired()
            .HasMaxLength(15);
            
        }
    }
}
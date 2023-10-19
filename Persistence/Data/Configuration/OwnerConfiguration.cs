using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Owner");

            builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(200);

            builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(p => p.Telephone)
            .IsRequired()
            .HasMaxLength(15);
            
        }
    }
}
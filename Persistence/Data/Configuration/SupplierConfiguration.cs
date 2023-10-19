using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Supplier");

            builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.Address)
            .IsRequired()
            .HasMaxLength(255);

            builder.Property(p => p.Telephone)
            .IsRequired()
            .HasMaxLength(15);
            

        }
    }
}
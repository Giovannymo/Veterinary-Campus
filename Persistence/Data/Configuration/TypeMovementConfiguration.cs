using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class TypeMovementConfiguration : IEntityTypeConfiguration<TypeMovement>
    {
        public void Configure(EntityTypeBuilder<TypeMovement> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Type_Movement");

            builder.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(100);

        }
    }
}
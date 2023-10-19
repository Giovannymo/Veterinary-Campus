using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MedicineMovementConfiguration : IEntityTypeConfiguration<MedicineMovement>
    {
        public void Configure(EntityTypeBuilder<MedicineMovement> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Medicine_Movement");

            builder.Property(e => e.Stock)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(e => e.DateMovement)
            .IsRequired()
            .HasColumnType("DateTime");

            builder.HasOne(p => p.TypeMovement)
            .WithMany(p => p.MedicineMovements)
            .HasForeignKey(p => p.IdTypeMovement);
        }
    }
}
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetailMovementConfiguration : IEntityTypeConfiguration<DetailMovement>
    {
        public void Configure(EntityTypeBuilder<DetailMovement> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("DetailMovement");

            builder.Property(e => e.Stock)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(e => e.Price)
            .IsRequired()
            .HasColumnType("double");

            builder.HasOne(p => p.MedicineMovement)
            .WithMany(p => p.DetailMovements)
            .HasForeignKey(p => p.IdMedicineMovementFk);

            builder.HasOne(p => p.Medicine)
            .WithMany(p => p.DetailMovements)
            .HasForeignKey(p => p.IdMedicineFk);
        }
    }
}
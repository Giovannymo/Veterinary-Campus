using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Pet");

            builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p => p.DayOfBirth)
            .IsRequired()
            .HasColumnType("DateTime");

            builder.HasOne(p => p.Owner)
            .WithMany(p => p.Pets)
            .HasForeignKey(p => p.IdOwnerFk);

            builder.HasOne(p => p.Race)
            .WithMany(p => p.Pets)
            .HasForeignKey(p => p.IdRaceFk);
        }
    }
}
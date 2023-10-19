using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class CitationConfiguration : IEntityTypeConfiguration<Citation>
    {

        public void Configure(EntityTypeBuilder<Citation> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Citation");

            
            builder.Property(e => e.Reason)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(e=> e.Date)
            .IsRequired()
            .HasColumnType("DateTime");

            builder.Property(e=> e.Time)
            .HasColumnType("DateTime")
            .HasMaxLength(100);

            builder.HasOne(p => p.Veterinarian)
            .WithMany(p => p.Citations)
            .HasForeignKey(p => p.IdVeterinarianFk);
        }
    }
}
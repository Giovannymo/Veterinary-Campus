using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MedicalTreatmentConfiguration : IEntityTypeConfiguration<MedicalTreatment>
    {
        public void Configure(EntityTypeBuilder<MedicalTreatment> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Medical_Treatment");

            builder.Property(e => e.Dosage)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(e => e.DateAdmin)
            .IsRequired()
            .HasColumnType("DateTime");

            builder.Property(e => e.Observation)
            .IsRequired()
            .HasMaxLength(255);

            builder.HasOne(p => p.Citation)
            .WithMany(p => p.MedicalTreatments)
            .HasForeignKey(p => p.IdCitationFk);

            builder.HasOne(p => p.Medicine)
            .WithMany(p => p.MedicalTreatments)
            .HasForeignKey(p => p.IdMedicineFk);




        }
    }
}
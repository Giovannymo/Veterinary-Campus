using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Medicine");

            builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(e => e.Stock)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(e => e.Price)
            .IsRequired()
            .HasColumnType("double");

            builder.HasOne(p => p.Laboratory)
            .WithMany(p => p.Medicines)
            .HasForeignKey(p => p.IdLaboratoryFk);
            
            builder
            .HasMany(m => m.Suppliers) //Campo de entitie Medicine
            .WithMany(s => s.Medicines)//entitie Supplier (por eso s)
            .UsingEntity<MedicineSupplier>(
                j => j 
                .HasOne(pt => pt.Supplier) //La tabla
                .WithMany(t => t.MedicineSuppliers) //Relaciona con la tabla
                .HasForeignKey(ut => ut.IdSupplierFk), //Donde existe un campo:

                j => j
                .HasOne(et => et.Medicine)
                .WithMany(et => et.MedicineSuppliers)
                .HasForeignKey(e => e.IdMedicineFk),
                j=>{
                    j.ToTable("Medicine_Suppliers");
                    j.HasKey(t => new { t.IdSupplierFk, t.IdMedicineFk});
                });

        }
    }
}
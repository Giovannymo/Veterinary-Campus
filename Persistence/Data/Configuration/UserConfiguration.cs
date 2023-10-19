using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("User");
            builder.Property(p => p.Name)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(p => p.Password)
           .HasMaxLength(255)
           .IsRequired();

            builder.Property(p => p.Email)
            .HasMaxLength(100)
            .IsRequired();

            builder
           .HasMany(p => p.Roles)
           .WithMany(r => r.Users)
           .UsingEntity<RolUser>(
               j => j
               .HasOne(pt => pt.Rol)
               .WithMany(t => t.RolUsers)
               .HasForeignKey(ut => ut.IdRolFk),
               j => j
               .HasOne(et => et.User)
               .WithMany(et => et.RolUsers)
               .HasForeignKey(el => el.IdUserFk),
               j =>
               {
                   j.ToTable("User_Rol");
                   j.HasKey(t => new { t.IdUserFk, t.IdRolFk });
               });

            builder.HasMany(p => p.RefreshTokens)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.IdUserFk);
        }
    }
}
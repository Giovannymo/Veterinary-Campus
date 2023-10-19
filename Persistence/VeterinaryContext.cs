
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class VeterinaryContext : DbContext
{
    public VeterinaryContext(DbContextOptions<VeterinaryContext> options) : base(options)
    {
        
    }

    public DbSet<Citation> Citations {get;set;}
    public DbSet<DetailMovement> DetailMovements {get;set;}
    public DbSet<Laboratory> Laboratories {get;set;}
    public DbSet<MedicalTreatment> MedicalTreatments {get;set;}
    public DbSet<Medicine> Medicines {get;set;}
    public DbSet<MedicineMovement> MedicineMovements {get;set;}
    public DbSet<MedicineSupplier> MedicineSuppliers {get;set;}
    public DbSet<Owner> Owners {get;set;}
    public DbSet<Pet> Pets {get;set;}
    public DbSet<Race> Races {get;set;}
    public DbSet<Rol> Rols {get;set;}
    public DbSet<RolUser> RolUsers {get;set;}
    public DbSet<Species> Species {get;set;}
    public DbSet<Supplier> Suppliers {get;set;}
    public DbSet<TypeMovement> TypeMovements {get;set;}
    public DbSet<User> Users {get;set;}
    public DbSet<Veterinarian> Veterinarians {get;set;}
    public DbSet<RefreshToken> RefreshTokens { get; set; }


     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

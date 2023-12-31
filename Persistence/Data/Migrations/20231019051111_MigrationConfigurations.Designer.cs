﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(VeterinaryContext))]
    [Migration("20231019051111_MigrationConfigurations")]
    partial class MigrationConfigurations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Citation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DateTime");

                    b.Property<int>("IdVeterinarianFk")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Time")
                        .HasMaxLength(100)
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.HasIndex("IdVeterinarianFk");

                    b.ToTable("Citation", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DetailMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMedicineFk")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicineMovementFk")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMedicineFk");

                    b.HasIndex("IdMedicineMovementFk");

                    b.ToTable("DetailMovement", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Laboratory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Laboratory", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MedicalTreatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdmin")
                        .HasColumnType("DateTime");

                    b.Property<int>("Dosage")
                        .HasColumnType("int");

                    b.Property<int>("IdCitationFk")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicineFk")
                        .HasColumnType("int");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("IdCitationFk");

                    b.HasIndex("IdMedicineFk");

                    b.ToTable("Medical_Treatment", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdLaboratoryFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLaboratoryFk");

                    b.ToTable("Medicine", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MedicineMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateMovement")
                        .HasColumnType("DateTime");

                    b.Property<int>("IdTypeMovement")
                        .HasColumnType("int");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTypeMovement");

                    b.HasIndex("OwnerId");

                    b.ToTable("Medicine_Movement", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MedicineSupplier", b =>
                {
                    b.Property<int>("IdSupplierFk")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicineFk")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdSupplierFk", "IdMedicineFk");

                    b.HasIndex("IdMedicineFk");

                    b.ToTable("Medicine_Suppliers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Owner", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DayOfBirth")
                        .HasColumnType("DateTime");

                    b.Property<int>("IdOwnerFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRaceFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdOwnerFk");

                    b.HasIndex("IdRaceFk");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdSpecieFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdSpecieFk");

                    b.ToTable("Race", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdUserFk");

                    b.ToTable("Refresh_Token", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Rol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RolUser", b =>
                {
                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRolFk")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdUserFk", "IdRolFk");

                    b.HasIndex("IdRolFk");

                    b.ToTable("User_Rol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Species", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TypeMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Type_Movement", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Veterinarian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Veterinarian", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Citation", b =>
                {
                    b.HasOne("Domain.Entities.Veterinarian", "Veterinarian")
                        .WithMany("Citations")
                        .HasForeignKey("IdVeterinarianFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veterinarian");
                });

            modelBuilder.Entity("Domain.Entities.DetailMovement", b =>
                {
                    b.HasOne("Domain.Entities.Medicine", "Medicine")
                        .WithMany("DetailMovements")
                        .HasForeignKey("IdMedicineFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.MedicineMovement", "MedicineMovement")
                        .WithMany("DetailMovements")
                        .HasForeignKey("IdMedicineMovementFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("MedicineMovement");
                });

            modelBuilder.Entity("Domain.Entities.MedicalTreatment", b =>
                {
                    b.HasOne("Domain.Entities.Citation", "Citation")
                        .WithMany("MedicalTreatments")
                        .HasForeignKey("IdCitationFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Medicine", "Medicine")
                        .WithMany("MedicalTreatments")
                        .HasForeignKey("IdMedicineFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Citation");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("Domain.Entities.Medicine", b =>
                {
                    b.HasOne("Domain.Entities.Laboratory", "Laboratory")
                        .WithMany("Medicines")
                        .HasForeignKey("IdLaboratoryFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laboratory");
                });

            modelBuilder.Entity("Domain.Entities.MedicineMovement", b =>
                {
                    b.HasOne("Domain.Entities.TypeMovement", "TypeMovement")
                        .WithMany("MedicineMovements")
                        .HasForeignKey("IdTypeMovement")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Owner", null)
                        .WithMany("MedicineMovements")
                        .HasForeignKey("OwnerId");

                    b.Navigation("TypeMovement");
                });

            modelBuilder.Entity("Domain.Entities.MedicineSupplier", b =>
                {
                    b.HasOne("Domain.Entities.Medicine", "Medicine")
                        .WithMany("MedicineSuppliers")
                        .HasForeignKey("IdMedicineFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Supplier", "Supplier")
                        .WithMany("MedicineSuppliers")
                        .HasForeignKey("IdSupplierFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Domain.Entities.Pet", b =>
                {
                    b.HasOne("Domain.Entities.Owner", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("IdOwnerFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Race", "Race")
                        .WithMany("Pets")
                        .HasForeignKey("IdRaceFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Domain.Entities.Race", b =>
                {
                    b.HasOne("Domain.Entities.Species", "Species")
                        .WithMany("Races")
                        .HasForeignKey("IdSpecieFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Species");
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.RolUser", b =>
                {
                    b.HasOne("Domain.Entities.Rol", "Rol")
                        .WithMany("RolUsers")
                        .HasForeignKey("IdRolFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("RolUsers")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Citation", b =>
                {
                    b.Navigation("MedicalTreatments");
                });

            modelBuilder.Entity("Domain.Entities.Laboratory", b =>
                {
                    b.Navigation("Medicines");
                });

            modelBuilder.Entity("Domain.Entities.Medicine", b =>
                {
                    b.Navigation("DetailMovements");

                    b.Navigation("MedicalTreatments");

                    b.Navigation("MedicineSuppliers");
                });

            modelBuilder.Entity("Domain.Entities.MedicineMovement", b =>
                {
                    b.Navigation("DetailMovements");
                });

            modelBuilder.Entity("Domain.Entities.Owner", b =>
                {
                    b.Navigation("MedicineMovements");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Domain.Entities.Race", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Navigation("RolUsers");
                });

            modelBuilder.Entity("Domain.Entities.Species", b =>
                {
                    b.Navigation("Races");
                });

            modelBuilder.Entity("Domain.Entities.Supplier", b =>
                {
                    b.Navigation("MedicineSuppliers");
                });

            modelBuilder.Entity("Domain.Entities.TypeMovement", b =>
                {
                    b.Navigation("MedicineMovements");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("RolUsers");
                });

            modelBuilder.Entity("Domain.Entities.Veterinarian", b =>
                {
                    b.Navigation("Citations");
                });
#pragma warning restore 612, 618
        }
    }
}

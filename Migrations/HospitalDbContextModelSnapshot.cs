﻿// <auto-generated />
using System;
using HospitalManagementSystem.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalManagementSystem.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    partial class HospitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HospitalManagementSystem.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("GSM_No")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("identification")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HospitalManagementSystem.Database.Admin", b =>
                {
                    b.HasBaseType("HospitalManagementSystem.Database.User");

                    b.Property<DateTime>("startDateOfEmployment")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("HospitalManagementSystem.Database.Doctor", b =>
                {
                    b.HasBaseType("HospitalManagementSystem.Database.User");

                    b.Property<string>("branch")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("HospitalManagementSystem.Database.Patient", b =>
                {
                    b.HasBaseType("HospitalManagementSystem.Database.User");

                    b.Property<string>("againPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("HospitalManagementSystem.Database.Secretary", b =>
                {
                    b.HasBaseType("HospitalManagementSystem.Database.User");

                    b.Property<string>("locationClinic")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("Secretary");
                });

            modelBuilder.Entity("HospitalManagementSystem.Database.Admin", b =>
                {
                    b.HasOne("HospitalManagementSystem.Database.User", "user")
                        .WithOne()
                        .HasForeignKey("HospitalManagementSystem.Database.Admin", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("HospitalManagementSystem.Database.Doctor", b =>
                {
                    b.HasOne("HospitalManagementSystem.Database.User", "user")
                        .WithOne()
                        .HasForeignKey("HospitalManagementSystem.Database.Doctor", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("HospitalManagementSystem.Database.Patient", b =>
                {
                    b.HasOne("HospitalManagementSystem.Database.User", "user")
                        .WithOne()
                        .HasForeignKey("HospitalManagementSystem.Database.Patient", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("HospitalManagementSystem.Database.Secretary", b =>
                {
                    b.HasOne("HospitalManagementSystem.Database.User", "user")
                        .WithOne()
                        .HasForeignKey("HospitalManagementSystem.Database.Secretary", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}

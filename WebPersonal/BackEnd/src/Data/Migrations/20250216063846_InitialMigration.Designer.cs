﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebPersonal.BackEnd.src.Data;

#nullable disable

namespace WebPersonal.BackEnd.src.data.migrations
{
    [DbContext(typeof(WebPersonalDbContext))]
    [Migration("20250216063846_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebPersonal.BackEnd.src.Model.Entity.EducationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("CertificatePdf")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EducationType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniversityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("WebPersonal.BackEnd.src.Model.Entity.ProfileEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GitHub")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("WebPersonal.BackEnd.src.Model.Entity.ProjectEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfileEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileEntityId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WebPersonal.BackEnd.src.Model.Entity.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfileEntityId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileEntityId");

                    b.HasIndex("ProjectEntityId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("WebPersonal.BackEnd.src.Model.Entity.ProjectEntity", b =>
                {
                    b.HasOne("WebPersonal.BackEnd.src.Model.Entity.ProfileEntity", null)
                        .WithMany("Projects")
                        .HasForeignKey("ProfileEntityId");
                });

            modelBuilder.Entity("WebPersonal.BackEnd.src.Model.Entity.Skill", b =>
                {
                    b.HasOne("WebPersonal.BackEnd.src.Model.Entity.ProfileEntity", null)
                        .WithMany("Skills")
                        .HasForeignKey("ProfileEntityId");

                    b.HasOne("WebPersonal.BackEnd.src.Model.Entity.ProjectEntity", null)
                        .WithMany("Skills")
                        .HasForeignKey("ProjectEntityId");
                });

            modelBuilder.Entity("WebPersonal.BackEnd.src.Model.Entity.ProfileEntity", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("WebPersonal.BackEnd.src.Model.Entity.ProjectEntity", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}

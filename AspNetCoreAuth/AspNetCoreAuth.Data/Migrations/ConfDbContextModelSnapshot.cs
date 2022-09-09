﻿// <auto-generated />
using System;
using AspNetCoreAuth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCoreAuth.Data.Migrations
{
    [DbContext(typeof(ConfDbContext))]
    partial class ConfDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AspNetCoreAuth.Data.Entities.Attendee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ConferenceId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Attendees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConferenceId = 1,
                            Name = "Lisa Overthere"
                        },
                        new
                        {
                            Id = 2,
                            ConferenceId = 1,
                            Name = "Robin Eisenberg"
                        },
                        new
                        {
                            Id = 3,
                            ConferenceId = 2,
                            Name = "Sue Mashmellow"
                        });
                });

            modelBuilder.Entity("AspNetCoreAuth.Data.Entities.Conference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Conferences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Salt Lake City",
                            Name = "Pluralshight Live1",
                            Start = new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Location = "Dhaka",
                            Name = "Pluralshight Live2",
                            Start = new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AspNetCoreAuth.Data.Entities.Proposal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<int>("ConferenceId")
                        .HasColumnType("int");

                    b.Property<string>("Speaker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Proposals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Approved = false,
                            ConferenceId = 1,
                            Speaker = "Roland Guijt",
                            Title = "Authentication and Authorization in ASP.NET Core"
                        },
                        new
                        {
                            Id = 2,
                            Approved = false,
                            ConferenceId = 2,
                            Speaker = "Cindy Reynolds",
                            Title = "Starting Your Developer Career"
                        },
                        new
                        {
                            Id = 3,
                            Approved = false,
                            ConferenceId = 2,
                            Speaker = "Heather Lipens",
                            Title = "ASP.NET Core TagHelpers"
                        });
                });

            modelBuilder.Entity("AspNetCoreAuth.Data.Entities.Attendee", b =>
                {
                    b.HasOne("AspNetCoreAuth.Data.Entities.Conference", "Conference")
                        .WithMany("Attendees")
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conference");
                });

            modelBuilder.Entity("AspNetCoreAuth.Data.Entities.Proposal", b =>
                {
                    b.HasOne("AspNetCoreAuth.Data.Entities.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conference");
                });

            modelBuilder.Entity("AspNetCoreAuth.Data.Entities.Conference", b =>
                {
                    b.Navigation("Attendees");
                });
#pragma warning restore 612, 618
        }
    }
}
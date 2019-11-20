﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PartyAtHomes_WebApi.Context;

namespace PartyAtHomes_WebApi.Migrations
{
    [DbContext(typeof(PartyAtHomesContext))]
    partial class PartyAtHomesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PartyAtHomes_Lib.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdressCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdressCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdressNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdressStreet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescriptionEvent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LocationLat")
                        .HasColumnType("float");

                    b.Property<double>("LocationLng")
                        .HasColumnType("float");

                    b.Property<string>("MainImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c1c3a63-834a-4d14-b040-fa41a02e1071"),
                            AdressCity = "Tielt",
                            AdressCountry = "Belgium",
                            AdressNumber = "3",
                            CreatorId = new Guid("2e6b0565-4412-431f-bab3-37c7fcdb725e"),
                            DescriptionEvent = "Test Event",
                            EndDateTime = new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Test",
                            LocationLat = 0.0,
                            LocationLng = 0.0,
                            StartDateTime = new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PartyAtHomes_Lib.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2e6b0565-4412-431f-bab3-37c7fcdb725e"),
                            FirstName = "chakalaka",
                            LastName = "Boom Boom",
                            Password = "123AZERTY",
                            UserName = "ChakBoom"
                        });
                });

            modelBuilder.Entity("PartyAtHomes_Lib.Event", b =>
                {
                    b.HasOne("PartyAtHomes_Lib.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

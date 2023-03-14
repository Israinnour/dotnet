﻿// <auto-generated />
using System;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    [DbContext(typeof(AMContext))]
    [Migration("20230314150120_tst1")]
    partial class tst1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AM.ApplicationCore.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"));

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EffectiveArival")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstimatedDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PlaneFK")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("PlaneFK");

                    b.ToTable("vols", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Passenger", b =>
                {
                    b.Property<string>("PassportNumber")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(80)
                        .HasColumnType("nchar")
                        .HasDefaultValue("name");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<long>("TelNumber")
                        .HasColumnType("bigint");

                    b.HasKey("PassportNumber");

                    b.ToTable("Pasengers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Passenger");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AM.ApplicationCore.Plane", b =>
                {
                    b.Property<int>("PlaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaneId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("PlaneCapacity");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlaneType")
                        .HasColumnType("int");

                    b.HasKey("PlaneId");

                    b.ToTable("MyPlanes", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Reservation", b =>
                {
                    b.Property<int>("SeatFk")
                        .HasColumnType("int");

                    b.Property<string>("PassengerFk")
                        .HasColumnType("nvarchar(7)");

                    b.Property<DateTime>("DateReservation")
                        .HasColumnType("datetime2");

                    b.HasKey("SeatFk", "PassengerFk", "DateReservation");

                    b.HasIndex("PassengerFk");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("AM.ApplicationCore.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("PlaneFK")
                        .HasColumnType("int");

                    b.Property<int?>("PlaneId")
                        .HasColumnType("int");

                    b.Property<string>("SeatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SectionFK")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("SeatId");

                    b.HasIndex("PlaneId");

                    b.HasIndex("SectionFK");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("AM.ApplicationCore.Section", b =>
                {
                    b.Property<int>("IdSection")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSection"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("IdSection");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("FlightPassenger", b =>
                {
                    b.Property<int>("FlightsFlightId")
                        .HasColumnType("int");

                    b.Property<string>("PassengersPassportNumber")
                        .HasColumnType("nvarchar(7)");

                    b.HasKey("FlightsFlightId", "PassengersPassportNumber");

                    b.HasIndex("PassengersPassportNumber");

                    b.ToTable("myPassenger", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Staff", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Passenger");

                    b.Property<DateTime>("EmployementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Function")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Staff");
                });

            modelBuilder.Entity("AM.ApplicationCore.Traveller", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Passenger");

                    b.Property<string>("HealthInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Traveller");
                });

            modelBuilder.Entity("AM.ApplicationCore.Flight", b =>
                {
                    b.HasOne("AM.ApplicationCore.Plane", "Plane")
                        .WithMany("Flights")
                        .HasForeignKey("PlaneFK")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Plane");
                });

            modelBuilder.Entity("AM.ApplicationCore.Reservation", b =>
                {
                    b.HasOne("AM.ApplicationCore.Passenger", "Passenger")
                        .WithMany("Reservations")
                        .HasForeignKey("PassengerFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.ApplicationCore.Seat", "Seat")
                        .WithMany("Reservations")
                        .HasForeignKey("SeatFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passenger");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("AM.ApplicationCore.Seat", b =>
                {
                    b.HasOne("AM.ApplicationCore.Plane", "Plane")
                        .WithMany("Seats")
                        .HasForeignKey("PlaneId");

                    b.HasOne("AM.ApplicationCore.Section", "Section")
                        .WithMany("Seats")
                        .HasForeignKey("SectionFK")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Plane");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("FlightPassenger", b =>
                {
                    b.HasOne("AM.ApplicationCore.Flight", null)
                        .WithMany()
                        .HasForeignKey("FlightsFlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.ApplicationCore.Passenger", null)
                        .WithMany()
                        .HasForeignKey("PassengersPassportNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Passenger", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("AM.ApplicationCore.Plane", b =>
                {
                    b.Navigation("Flights");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("AM.ApplicationCore.Seat", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("AM.ApplicationCore.Section", b =>
                {
                    b.Navigation("Seats");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using FlyTodayDatabaseImplements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FlyTodayDatabaseImplements.Migrations
{
    [DbContext(typeof(FlyTodayDatabase))]
    partial class FlyTodayDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.BoardingPass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PlaceId")
                        .HasColumnType("integer");

                    b.Property<int>("TicketId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.HasIndex("TicketId");

                    b.ToTable("BoardingPasses");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Direction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CityFrom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CityTo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CountryFrom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CountryTo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Directions");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateMedAnalys")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("FlightId")
                        .HasColumnType("integer");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("MedAnalys")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PositionAtWorkId")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("PositionAtWorkId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("BusinessPrice")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DirectionId")
                        .HasColumnType("integer");

                    b.Property<double>("EconomPrice")
                        .HasColumnType("double precision");

                    b.Property<int>("FlightStatus")
                        .HasColumnType("integer");

                    b.Property<int>("FreePlacesCountBusiness")
                        .HasColumnType("integer");

                    b.Property<int>("FreePlacesCountEconom")
                        .HasColumnType("integer");

                    b.Property<int>("PlaneId")
                        .HasColumnType("integer");

                    b.Property<int>("TimeInFlight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DirectionId");

                    b.HasIndex("PlaneId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.FlightSubscriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FlightId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("UserId");

                    b.ToTable("FlightSubscribers");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FlightId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsFree")
                        .HasColumnType("boolean");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Plane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BusinessPlacesCount")
                        .HasColumnType("integer");

                    b.Property<int>("EconomPlacesCount")
                        .HasColumnType("integer");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PlaneSchemeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PlaneSchemeId");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.PlaneScheme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BusinessPlacesCount")
                        .HasColumnType("integer");

                    b.Property<int>("EconomPlacesCount")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PlacesInFirstLineBusiness")
                        .HasColumnType("integer");

                    b.Property<int>("PlacesInFirstLineEconom")
                        .HasColumnType("integer");

                    b.Property<int>("PlacesInLastLineBusiness")
                        .HasColumnType("integer");

                    b.Property<int>("PlacesInLastLineEconom")
                        .HasColumnType("integer");

                    b.Property<int>("PlacesInMiddleLineEconom")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PlaneSchemes");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.PositionAtWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("NumberOfEmployeesInShift")
                        .HasColumnType("integer");

                    b.Property<string>("TypeWork")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PositionAtWorks");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Cost")
                        .HasColumnType("double precision");

                    b.Property<int>("FlightId")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfBusiness")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfEconomy")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("UserId");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AgeFrom")
                        .HasColumnType("integer");

                    b.Property<int?>("AgeTo")
                        .HasColumnType("integer");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Percent")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<bool>("Presence")
                        .HasColumnType("boolean");

                    b.Property<string>("Shift")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Bags")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DateOfBirthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NumberOfDocument")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RentId")
                        .HasColumnType("integer");

                    b.Property<int?>("SaleId")
                        .HasColumnType("integer");

                    b.Property<string>("SeriesOfDocument")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("TicketCost")
                        .HasColumnType("double precision");

                    b.Property<string>("TypeTicket")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RentId");

                    b.HasIndex("SaleId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessRule")
                        .HasColumnType("integer");

                    b.Property<bool>("AllowNotifications")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DateOfBirthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.BoardingPass", b =>
                {
                    b.HasOne("FlyTodayDatabaseImplements.Models.Place", "Place")
                        .WithMany("BoardingPasses")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlyTodayDatabaseImplements.Models.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Employee", b =>
                {
                    b.HasOne("FlyTodayDatabaseImplements.Models.Flight", null)
                        .WithMany("Employees")
                        .HasForeignKey("FlightId");

                    b.HasOne("FlyTodayDatabaseImplements.Models.PositionAtWork", "PositionAtWork")
                        .WithMany()
                        .HasForeignKey("PositionAtWorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PositionAtWork");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Flight", b =>
                {
                    b.HasOne("FlyTodayDatabaseImplements.Models.Direction", "Direction")
                        .WithMany("Flights")
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlyTodayDatabaseImplements.Models.Plane", "Plane")
                        .WithMany()
                        .HasForeignKey("PlaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direction");

                    b.Navigation("Plane");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.FlightSubscriber", b =>
                {
                    b.HasOne("FlyTodayDatabaseImplements.Models.Flight", "Flight")
                        .WithMany("Subscribers")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlyTodayDatabaseImplements.Models.User", "User")
                        .WithMany("FlightSubscribers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Plane", b =>
                {
                    b.HasOne("FlyTodayDatabaseImplements.Models.PlaneScheme", "PlaneScheme")
                        .WithMany("Planes")
                        .HasForeignKey("PlaneSchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlaneScheme");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Rent", b =>
                {
                    b.HasOne("FlyTodayDatabaseImplements.Models.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlyTodayDatabaseImplements.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Schedule", b =>
                {
                    b.HasOne("FlyTodayDatabaseImplements.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Ticket", b =>
                {
                    b.HasOne("FlyTodayDatabaseImplements.Models.Rent", "Rent")
                        .WithMany()
                        .HasForeignKey("RentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlyTodayDatabaseImplements.Models.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("SaleId");

                    b.Navigation("Rent");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Direction", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Flight", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Subscribers");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.Place", b =>
                {
                    b.Navigation("BoardingPasses");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.PlaneScheme", b =>
                {
                    b.Navigation("Planes");
                });

            modelBuilder.Entity("FlyTodayDatabaseImplements.Models.User", b =>
                {
                    b.Navigation("FlightSubscribers");
                });
#pragma warning restore 612, 618
        }
    }
}

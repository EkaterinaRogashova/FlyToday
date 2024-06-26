﻿using FlyTodayDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;

namespace FlyTodayDatabaseImplements
{
    public class FlyTodayDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FlyTodayBd;Username=postgres;Password=1234");
                //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FlyTodayBd;Username=postgres;Password=1234");
                //optionsBuilder.UseNpgsql("Host=192.168.1.65;Port=5432;Database=FlyTodayBd;Username=tanya;Password=1234");
                //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FlyTodayBd;Username=postgres;Password=12345");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<BoardingPass> BoardingPasses { set; get; }
        public virtual DbSet<Direction> Directions { set; get; }
        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Flight> Flights { set; get; }
        public virtual DbSet<Place> Places { set; get; }
        public virtual DbSet<Plane> Planes { set; get; }
        public virtual DbSet<Rent> Rents { set; get; }
        public virtual DbSet<Sale> Sales { set; get; }
        public virtual DbSet<Schedule> Schedules { set; get; }
        public virtual DbSet<Ticket> Tickets { set; get; }
        public virtual DbSet<User> Users { set; get; }
        public virtual DbSet<PositionAtWork> PositionAtWorks { set; get; }
        public virtual DbSet<FlightSubscriber> FlightSubscribers { set; get; }
        public virtual DbSet<PlaneScheme> PlaneSchemes { set; get; }
    }
}

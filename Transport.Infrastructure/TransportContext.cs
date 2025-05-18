using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Transport.Infrastructure.Models;

namespace Transport.Infrastructure
{
    public class TransportContext : DbContext
    {
        public TransportContext(DbContextOptions<TransportContext> options) : base(options) { }

        public DbSet<BusModel> Buses { get; set; }
        public DbSet<DriverModel> Drivers { get; set; }
        public DbSet<RouteModel> Routes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1-до-1
            modelBuilder.Entity<BusModel>()
                .HasOne(b => b.Driver)
                .WithOne(d => d.Bus)
                .HasForeignKey<DriverModel>(d => d.BusModelId);

            // 1-до-багатьох
            modelBuilder.Entity<BusModel>()
                .HasMany(b => b.Routes)
                .WithOne(r => r.Bus)
                .HasForeignKey(r => r.BusModelId);
        }
    }
}

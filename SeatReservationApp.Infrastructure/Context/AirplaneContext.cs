using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SeatReservationApp.Airplanes.Domain.Entities;

namespace SeatReservationApp.Infrastructure.Context
{
    public class AirplaneContext : DbContext
    {

        public AirplaneContext(): base("AirplaneContext")
        {
            
        }

        public DbSet<Airplane> Airplanes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Airplane>().HasKey<int>(l => l.Id);
            modelBuilder.Entity<Seat>().HasKey<int>(l => l.Id);
            base.OnModelCreating(modelBuilder);

        }

    }
}
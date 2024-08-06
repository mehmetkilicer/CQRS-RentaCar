using Microsoft.EntityFrameworkCore;

namespace CQRS_RentaCar.DAL
{
    public class CarRentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-91LH8V7\\SQLEXPRESS;initial catalog=DbCarRental;integrated Security=true;TrustServerCertificate=True;");
        }
        public DbSet<BodyStyle> BodyStyles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarRental> CarRentals { get; set; }
        public DbSet<RentalLocation> RentalLocations { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarRental>()
                .HasOne(cr => cr.StartLocation)
                .WithMany(rl => rl.StartRentals)
                .HasForeignKey(cr => cr.StartLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CarRental>()
                .HasOne(cr => cr.EndLocation)
                .WithMany(rl => rl.EndRentals)
                .HasForeignKey(cr => cr.EndLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.RentalLocation)
                .WithMany(rl => rl.Vehicles)
                .HasForeignKey(v => v.RentalLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Brand)
                .WithMany(b => b.Vehicles)
                .HasForeignKey(v => v.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.BodyStyle)
                .WithMany(bs => bs.Vehicles)
                .HasForeignKey(v => v.BodyStyleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

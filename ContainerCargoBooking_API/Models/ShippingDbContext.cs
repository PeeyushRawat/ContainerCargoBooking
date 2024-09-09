using Microsoft.EntityFrameworkCore;

namespace ContainerCargoBooking_API.Models
{
    public class ShippingDbContext : DbContext
    {
        public ShippingDbContext(DbContextOptions<ShippingDbContext> options) : base(options)
        {
        }

        // DbSet properties for your entities
        public DbSet<User> Users { get; set; }
        public DbSet<Port> Ports { get; set; }
        public DbSet<ShippingCompany> ShippingCompanies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Container> Containers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User-Booking Relationship (One-to-Many)
            modelBuilder.Entity<Booking>()
                .HasOne<User>(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId);

            // Container-Booking Relationship (One-to-Many)
            modelBuilder.Entity<Booking>()
                .HasOne<Container>(b => b.Container)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.ContainerId);

            // Port-Booking Relationship (One-to-Many) for SourcePort
            modelBuilder.Entity<Booking>()
                .HasOne<Port>(b => b.SourcePort)
                .WithMany()
                .HasForeignKey(b => b.SourcePortId)
                .OnDelete(DeleteBehavior.Restrict);  // Optional: Use Restrict to prevent cascading deletes

            // Port-Booking Relationship (One-to-Many) for DestinationPort
            modelBuilder.Entity<Booking>()
                .HasOne<Port>(b => b.DestinationPort)
                .WithMany()
                .HasForeignKey(b => b.DestinationPortId)
                .OnDelete(DeleteBehavior.Restrict);  // Optional: Use Restrict to prevent cascading deletes


            base.OnModelCreating(modelBuilder);
        }

    }

}

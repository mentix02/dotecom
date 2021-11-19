using ecom.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecom.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.ApplicationUser)
                .HasForeignKey<Cart>(c => c.ApplicationUserId);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Address)
                .WithOne(a => a.Order)
                .HasForeignKey<Address>(a => a.OrderId);
        }

        public override int SaveChanges()
        {
            var orderEntries = ChangeTracker.Entries().Where(e => e.Entity is Order && e.State == EntityState.Added);
            foreach (var orderEntry in orderEntries)
            {
                ((Order)orderEntry.Entity).Timestamp = DateTime.Now;
            }
            var applicationUserEntries = ChangeTracker.Entries().Where(e => e.Entity is ApplicationUser && e.State == EntityState.Added);
            foreach (var applicationUserEntry in applicationUserEntries)
            {
                var user = ((ApplicationUser)applicationUserEntry.Entity);
                if (user.Cart == null)
                {
                    var cart = new Cart() { ApplicationUserId = user.Id };
                    this.Carts.Add(cart);
                }
            }
            return base.SaveChanges();
        }

    }
}
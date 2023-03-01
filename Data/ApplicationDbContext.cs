
using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


using Online_Resturent_1.Models;


//ResDbContext
namespace Online_Resturent_1.Data
{
    public class ApplicationDbContext : DbContext
    {


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;uid=root;pwd=Sud2617#;database=Online_Resturent", new MySqlServerVersion(new Version(8, 0, 31)));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //customer order relationship

            modelBuilder.Entity<Customer>()
                     .HasMany(c => c.Orders)
                     .WithOne(o => o.Customer)
                     .HasForeignKey(o => o.Cu_ID);

            modelBuilder.Entity<Customer>()
                    .HasMany(c => c.Orders)
                    .WithOne(o => o.Customer)
                    .HasForeignKey(o => o.Cu_ID);

            //orde payment relationship

            modelBuilder.Entity<Order>()
                    .HasOne(o => o.Payment)
                    .WithOne(p => p.Order)
                    .HasForeignKey<Payment>(p => p.Or_ID);

            //order food relationship

            modelBuilder.Entity<Food>()
                    .HasOne(f => f.Order)
                    .WithMany(o => o.Foods)
                    .HasForeignKey(f => f.Or_ID);
        }

    }
}

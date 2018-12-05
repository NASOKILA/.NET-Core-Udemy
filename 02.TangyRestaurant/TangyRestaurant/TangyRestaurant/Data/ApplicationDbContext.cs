using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TangyRestaurant.Models;

namespace TangyRestaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

        //DbSets
        public DbSet<Category> Categories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<Coupon> Coupons { get; set; }
        
        //Connection string
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //Table connections
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}

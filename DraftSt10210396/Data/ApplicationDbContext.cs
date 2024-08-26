using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DraftSt10210396.Models;

namespace DraftSt10210396.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        //public DbSet<DraftSt10210396.Models.Product> Product { get; set; } = default!;
        //public DbSet<DraftSt10210396.Models.Order> Order { get; set; } = default!;
    }
}

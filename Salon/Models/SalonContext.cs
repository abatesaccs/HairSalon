using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class SalonContext : DbContext
  {
    public virtual DbSet<Category> Stylists { get; set; }
    public DbSet<Item> Customers { get; set; }
    
    public SalonContext(DbContextOptions options) : base(options) { }
  }
}
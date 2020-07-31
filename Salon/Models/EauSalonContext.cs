using Microsoft.EntityFrameworkCore;

namespace EauSalon.Models
{
  public class EauSalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
    public EauSalonContext(DbContextOptions options) : base(options) { }
  }
}
using ces.Models;
using Microsoft.EntityFrameworkCore;
using Route = ces.Models.Route;

namespace ces.ORM;

public partial class ApplicationDbContext : DbContext
{
    public DbSet<City> Cities { get; set; }
    public DbSet<Customer> Customers { get; set;}
    public DbSet<Order> Orders { get; set; }
    public DbSet<ParcelType> ParcelTypes { get; set; }
    public DbSet<Route> Routes { get; set; }

    public ApplicationDbContext()
    {

    }

    public ApplicationDbContext(DbContextOptions options)
            : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

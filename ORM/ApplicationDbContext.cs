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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using ces.Models;
using Microsoft.EntityFrameworkCore;

namespace ces.ORM;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
    {
    }

    public DbSet<City> Cities { get; set; }

    public async Task<int> SaveChanges()
    {
        return await base.SaveChangesAsync();
    }
}

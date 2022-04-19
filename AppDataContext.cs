using Microsoft.EntityFrameworkCore;

namespace cherry_blossom;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options)
        : base(options)
    {

    }

    public DbSet<Library> Libraries { get; set; }
}
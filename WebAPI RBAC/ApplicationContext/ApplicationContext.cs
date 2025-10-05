using Microsoft.EntityFrameworkCore;
using WebAPI_RBAC.Models;

namespace WebAPI_RBAC.ApplicationContext;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    private const string DefaultSchema = "api";
    
    public DbSet<BookModel> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
    }
}
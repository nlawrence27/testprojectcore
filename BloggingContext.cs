using Microsoft.EntityFrameworkCore;

public class BloggingContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=proof;Username=postgres;Password=Arond1ght$;");   
    }
}
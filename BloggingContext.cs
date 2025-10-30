using Microsoft.EntityFrameworkCore;

public class BloggingContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=proof;Username=postgres;Password=root;");
        //optionsBuilder.UseSqlServer("Server=localhost;Database=proof;User Id=sa;Password=Arond1ght$;"); versión anterior
    }
}

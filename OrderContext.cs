
using Microsoft.EntityFrameworkCore;
Console.WriteLine();
public class OrderContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=db-ecommerce;User=sa;Password=Scheggia12$;");
        //"myCustomConnString": "Server=localhost,1433\\Catalog=myDatabase;Database=myDatabase;User=username;Password=MYSecurePWD;"

    }
}
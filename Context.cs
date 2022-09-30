
using System.Linq;
using Microsoft.EntityFrameworkCore;
Console.WriteLine();


//OrderContext db = new OrderContext();
//Customer newCustomer = new Customer();
//newCustomer.Name = "gabriele";
//newCustomer.Surname = "baglioni";
//newCustomer.Email = "gabrielebagliomi@gmail";
//db.Add(newCustomer);
//db.SaveChanges();



using (OrderContext db = new OrderContext())
{
    db.Add(new Customer("John", "Doe", "12345678910"));
    db.Add(new Customer("Mike", "Poe", "12345678910"));
    db.Add(new Customer("Alex", "Foe", "12345678910"));
    db.Add(new Customer("Smith", "Goe", "12345678910"));
    db.SaveChanges();

    //read

    List<Customer> customers = db.Customers.OrderBy(customers => customers.Name).ToList();
}


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
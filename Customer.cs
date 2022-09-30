

public partial class Customer
{
    

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
   
    public virtual ICollection<Order> Orders { get; set; }

    public Customer(string name, string surname, string email)
    {
        Name = name;
        Surname = surname;
        Email = email;
    }
}
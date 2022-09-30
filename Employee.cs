public partial class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Level { get; set; }

    public virtual ICollection<Order> Orders { get; set; }

}
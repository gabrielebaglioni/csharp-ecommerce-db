﻿

public partial class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
   
    public virtual ICollection<Order> Orders { get; set; }
}
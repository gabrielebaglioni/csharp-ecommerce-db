using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal Price { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; }
}
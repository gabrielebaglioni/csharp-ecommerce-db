using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal Amount { get; set; }
    public string Status { get; set; }
    
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }

    public virtual ICollection<Payment> Payaments { get; set; }

    public virtual ICollection<Product> Products { get; set; }

}


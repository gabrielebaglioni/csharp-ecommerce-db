using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Payment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal Amount { get; set; }
    public string Status { get; set; }
  
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }

}
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPA.Data;

public class Shipper
{
    public int ShipperId { get; set; }
    
    [MaxLength(40)]
    public string CompanyName { get; set; } = null!;
    
    [MaxLength(24)]
    public string? Phone { get; set; }

    [InverseProperty(nameof(Order.Shipper))]
    public virtual ICollection<Order>? Orders { get; set; }
    
}
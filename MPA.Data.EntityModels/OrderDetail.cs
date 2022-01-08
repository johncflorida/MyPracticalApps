using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPA.Data;

public class OrderDetail
{
    [Key]
    public int OrderId { get; set; }
    
    [Key]
    public int ProductId { get; set; }
    
    [Required]
    public decimal UnitPrice { get; set; }
    
    [Required]
    public short Quantity { get; set; }
    
    [Required]
    public decimal Discount { get; set; }

    [ForeignKey(nameof(OrderId))]
    [InverseProperty("OrderDetails")]
    public Order? Order { get; set; } = null!;

    [ForeignKey(nameof(ProductId))]
    [InverseProperty("OrderDetails")]
    public Product? Product { get; set; } = null!;

}
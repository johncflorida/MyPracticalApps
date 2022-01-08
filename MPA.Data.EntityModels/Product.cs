using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPA.Data;

public class Product
{
    public int ProductId { get; set; }

    [MaxLength(40)]
    public string ProductName { get; set; } = null!;
    
    public int? SupplierId { get; set; }
    
    public int? CategoryId { get; set; }
    
    [MaxLength(20)]
    public string? QuantityPerUnit { get; set; }
    
    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }

    public short? UnitsOnOrder { get; set; }

    public short? ReorderLevel { get; set; }

    public bool Discontinued { get; set; }
   
    [ForeignKey(nameof(SupplierId))]
    [InverseProperty("Products")]
    public Supplier? Supplier { get; set; }

    [ForeignKey(nameof(CategoryId))]
    [InverseProperty("Products")]
    public Category? Category { get; set; }
    
    [InverseProperty(nameof(OrderDetail.Product))]
    public ICollection<OrderDetail>? OrderDetails { get; set; }

}
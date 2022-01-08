using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPA.Data;

public class Category
{
    public int CategoryId { get; set; }
    
    [Required]
    [MaxLength(15)]
    public string CategoryName { get; set; } = null!;
    
    public string? Description { get; set; }
    
    public byte[]? Picture { get; set; }

    [InverseProperty(nameof(Product.Category))]
    public virtual ICollection<Product>? Products { get; set; }

}
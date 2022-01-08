using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPA.Data;

public class Order
{
    public int OrderId { get; set; }

    [RegularExpression("[A-Z]{5}")]
    public string? CustomerId { get; set; }
    
    public int? EmployeeId { get; set; }
    
    public DateTime? OrderDate { get; set; }
    
    public DateTime? RequiredDate { get; set; }
    
    public DateTime? ShippedDate { get; set; }
    
    public int? ShipVia { get; set; }
    
    public decimal? Freight { get; set; } = 0M;
    
    [MaxLength(40)]
    public string? ShipName { get; set; }
    
    [MaxLength(60)]
    public string? ShipAddress { get; set; }
    
    [MaxLength(15)]
    public string? ShipCity { get; set; }
    
    [MaxLength(15)]
    public string? ShipRegion { get; set; }
    
    [MaxLength(10)]
    public string? ShipPostalCode { get; set; }
    
    [MaxLength(15)]
    public string? ShipCountry { get; set; }

    [ForeignKey(nameof(CustomerId))]
    [InverseProperty("Orders")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey(nameof(EmployeeId))]
    [InverseProperty("Orders")]
    public virtual Employee? Employee { get; set; }

    [ForeignKey(nameof(ShipVia))]
    [InverseProperty("Orders")]
    public virtual Shipper? Shipper { get; set; }

    [InverseProperty(nameof(OrderDetail.Order))]
    public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

}
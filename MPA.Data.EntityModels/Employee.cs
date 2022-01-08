using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPA.Data;

public class Employee
{
    public int EmployeeId { get; set; }

    [Required]
    [MaxLength(20)]
    public string LastName { get; set; } = null!;

    [Required]
    [MaxLength(10)]
    public string FirstName { get; set; } = null!;

    [MaxLength(30)]
    public string? Title { get; set; }

    [MaxLength(25)]
    public string? TitleOfCourtesy { get; set; }
    
    public DateTime? BirthDate { get; set; }
    
    public DateTime? HireDate { get; set; }

    [MaxLength(60)]
    public string? Address { get; set; }

    [MaxLength(15)]
    public string? City { get; set; }

    [MaxLength(15)]
    public string? Region { get; set; }

    [MaxLength(10)]
    public string? PostalCode { get; set; }

    [MaxLength(15)]
    public string? Country { get; set; }

    [MaxLength(24)]
    public string? HomePhone { get; set; }

    [MaxLength(4)]
    public string? Extension { get; set; }
    
    public byte[]? Photo { get; set; }
    
    public string? Notes { get; set; }
    
    public int? ReportsTo { get; set; }

    [MaxLength(255)]
    public string? PhotoPath { get; set; }

    [InverseProperty(nameof(Order.Employee))]
    public virtual ICollection<Order>? Orders { get; set; }

}
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MPA.Data;

public class EmployeeTerritory
{
    [Required]
    public int EmployeeId { get; set; }

    [Required]
    [MaxLength(20)]
    public string TerritoryId { get; set; } = null!;

}
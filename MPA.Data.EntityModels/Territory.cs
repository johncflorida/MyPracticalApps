using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MPA.Data;

public class Territory
{
    [MaxLength(20)]
    public string TerritoryId { get; set; } = null!;

    [MaxLength(50)]
    public string TerritoryDescription { get; set; } = null!;

    public int RegionId { get; set; }
    
}
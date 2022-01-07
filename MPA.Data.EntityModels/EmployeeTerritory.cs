using Microsoft.EntityFrameworkCore;

namespace MPA.Data;

public class EmployeeTerritory
{
    public int? EmployeeId { get; set; } = null!;
    public string? TerritoryId { get; set; } = null!;

}
using Microsoft.EntityFrameworkCore;

namespace MPA.Data;

public class Category
{
    public int? CategoryId { get; set; } = null!;
    public string? CategoryName { get; set; } = null!;
    public string? Description { get; set; }
    public byte[]? Picture { get; set; }

}
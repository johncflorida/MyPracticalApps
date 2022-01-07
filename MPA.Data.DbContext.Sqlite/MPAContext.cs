using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace MPA.Data;

public class MPAContext : DbContext
{
    public virtual DbSet<Category> Categories { get; set; } = null!;
    public virtual DbSet<Customer> Customers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite(@"Data Source=..\MPA.Data.DbContext.Sqlite\MPA.db;");
        }
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity => 
        {
            entity.HasKey(c => c.CategoryId);

            entity.Property(c => c.CategoryId).HasColumnType("int");

            entity.Property(c => c.CategoryName).HasColumnType("nvarchar(15)").HasMaxLength(15).IsRequired();

            entity.Property(c => c.Description).HasColumnType("ntext");

            entity.Property(c => c.Picture).HasColumnType("image");
        });

        modelBuilder.Entity<Customer>(entity => 
        {
            entity.HasKey(c => c.CustomerId);

            entity.Property(c => c.CustomerId).HasColumnType("nchar(5)").HasMaxLength(5).IsRequired();

            entity.Property(c => c.CompanyName).HasColumnType("nvarchar(40)").HasMaxLength(40).IsRequired();

            entity.Property(c => new {c.ContactName, c.ContactTitle}).HasColumnType("nvarchar(30)").HasMaxLength(30);

            entity.Property(c => c.Address).HasColumnType("nvarchar(60)").HasMaxLength(60);

            entity.Property(c => new {c.City, c.Region, c.Country}).HasColumnType("nvarchar(15)").HasMaxLength(15);

            entity.Property(c => c.PostalCode).HasColumnType("nvarchar(10)").HasMaxLength(10);

            entity.Property(c => new {c.Phone, c.Fax}).HasColumnType("nvarchar(24)").HasMaxLength(24);

        });

        modelBuilder.Entity<Employee>(entity => 
        {
            entity.HasKey(c => c.EmployeeId);

            entity.Property(c => c.EmployeeId).HasColumnType("int");

            entity.Property(c => c.LastName).HasColumnType("nvarchar(20)").HasMaxLength(20).IsRequired();

            entity.Property(c => c.FirstName).HasColumnType("nvarchar(10)").HasMaxLength(10).IsRequired();

            entity.Property(c => c.Title).HasColumnType("nvarchar(30)").HasMaxLength(30);

            entity.Property(c => c.TitleOfCourtesy).HasColumnType("nvarchar(25)").HasMaxLength(25);

            entity.Property(c => new {c.BirthDate, c.HireDate}).HasColumnType("datetime");

            entity.Property(c => c.Address).HasColumnType("nvarchar(60)").HasMaxLength(60);

            entity.Property(c => new {c.City, c.Region, c.Country}).HasColumnType("nvarchar(15)").HasMaxLength(15);

            entity.Property(c => c.PostalCode).HasColumnType("nvarchar(10)").HasMaxLength(10);

            entity.Property(c => c.HomePhone).HasColumnType("nvarchar(24)").HasMaxLength(24);

            entity.Property(c => c.Extension).HasColumnType("nvarchar(4)").HasMaxLength(4);

            entity.Property(c => c.Photo).HasColumnType("image");

            entity.Property(c => c.Notes).HasColumnType("ntext");

            entity.Property(c => c.ReportsTo).HasColumnType("int");
            
            entity.Property(c => c.PhotoPath).HasColumnType("nvarchar(255)").HasMaxLength(255);

        });

        modelBuilder.Entity<EmployeeTerritory>(entity => 
        {
            entity.HasKey(c => c.EmployeeId);

            entity.Property(c => c.EmployeeId).HasColumnType("int");

            entity.Property(c => c.TerritoryId).HasColumnType("nvarchar(20)").HasMaxLength(20).IsRequired();

        });
    }

}
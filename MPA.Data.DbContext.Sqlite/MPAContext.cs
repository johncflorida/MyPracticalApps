using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace MPA.Data;

public class MPAContext : DbContext
{
    public virtual DbSet<Category> Categories { get; set; } = null!;
    public virtual DbSet<Customer> Customers { get; set; } = null!;
    public virtual DbSet<Employee> Employees { get; set; } = null!;
    public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; } = null!;
    public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    public virtual DbSet<Order> Orders { get; set; } = null!;
    public virtual DbSet<Product> Products { get; set; } = null!;
    public virtual DbSet<Shipper> Shippers { get; set; } = null!;
    public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
    public virtual DbSet<Territory> Territories { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite(@"Data Source=..\MPA.Data.DbContext.Sqlite\MPA.db;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.ToTable("Order Detail");
            entity.HasOne(a => a.Order)
                .WithMany(b => b.OrderDetails)
                .HasForeignKey(a => a.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            entity.HasOne(a => a.Product)
                .WithMany(b => b.OrderDetails)
                .HasForeignKey(a => a.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Territory>(entity =>
        {
            entity.HasNoKey();

        });

    }

}
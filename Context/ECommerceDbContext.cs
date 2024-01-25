using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Entities;

namespace ECommerceAPI.Context;
public class ECommerceDbContext : DbContext
{
    protected IConfiguration Configuration;
    public ECommerceDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Configuration.GetValue<string>("ConnectionStrings:Developer");
        optionsBuilder.UseSqlServer(connectionString);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductComment> ProductComments { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<OrderCancelled> OrderCancelledes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
}

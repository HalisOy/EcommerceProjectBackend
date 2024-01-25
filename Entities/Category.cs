using ECommerceAPI.Core;

namespace ECommerceAPI.Entities;
public class Category : Entity<Guid>
{
    public required string Name { get; set; }
    public virtual IEnumerable<Product>? Products { get; set; }
    public Category()
    {
        Products = new HashSet<Product>();
    }
}

using ECommerceAPI.Core;

namespace ECommerceAPI.Entities;
public class ProductComment:Entity<Guid>
{
    public required Guid ProductId { get; set; }
    public required byte Rating { get; set; }
    public required string Comment { get; set; }
}

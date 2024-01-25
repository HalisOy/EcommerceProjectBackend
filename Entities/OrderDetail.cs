using ECommerceAPI.Core;

namespace ECommerceAPI.Entities;
public class OrderDetail : Entity<Guid>
{
    public required Guid OrderId { get; set; }
    public required Guid ProductId { get; set; }
    public required int Price { get; set; }
    public required ushort Quantity { get; set; }
    public virtual Product? Product { get; set; }
}

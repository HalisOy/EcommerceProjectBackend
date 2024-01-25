using ECommerceAPI.Core;

namespace ECommerceAPI.Entities;
public class CartItem: Entity<Guid>
{
    public required Guid CartId { get; set; }
    public required Guid ProductId { get; set; }
    public required ushort Quantity { get; set; }
}

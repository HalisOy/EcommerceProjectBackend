using ECommerceAPI.Core;

namespace ECommerceAPI.Entities;

public class Cart : Entity<Guid>
{
    public Guid UserId { get; set; }
    public int TotalAmount { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }
    public Cart()
    {
        CartItems = new HashSet<CartItem>();
    }
}

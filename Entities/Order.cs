using ECommerceAPI.Core;

namespace ECommerceAPI.Entities;
public class Order : Entity<Guid>
{
    public required Guid UserId { get; set; }
    public required DateTime CreatedDate { get; set; }
    public required string Status { get; set; }
    public virtual User? User { get; set; }
    public virtual IEnumerable<OrderCancelled>? OrderCancelledes { get; set; }
    public virtual IEnumerable<OrderDetail>? OrderDetails { get; set; }
    public Order()
    {
        OrderDetails = new HashSet<OrderDetail>();
        OrderCancelledes = new HashSet<OrderCancelled>();
    }
}

/*
    Status
    --------------------
    Ready,
    Posted,
    Deliver
    Canceled,
    RePosted
 
 */
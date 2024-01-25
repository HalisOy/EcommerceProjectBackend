using ECommerceAPI.Core;

namespace ECommerceAPI.Entities;
public class OrderCancelled : Entity<Guid>
{
    public required Guid OrderId { get; set; }
    public required string CancellationTitle { get; set; }
    public required string CancellationSubject { get; set; }
}

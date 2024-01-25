using ECommerceAPI.Core;

namespace ECommerceAPI.Entities;
public class Product : Entity<Guid>
{
    public required Guid UserId { get; set; }
    public required Guid CategoryId { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public virtual User? User { get; set; }
    public virtual Category? Category { get; set; }
    public virtual ProductComment? Comments { get; set; }
}

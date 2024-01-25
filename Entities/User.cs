using ECommerceAPI.Core;

namespace ECommerceAPI.Entities;
public class User : Entity<Guid>
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string IdentityNumber { get; set; }
    public required DateTime BirthDay { get; set; }
}

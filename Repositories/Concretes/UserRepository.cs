using ECommerceAPI.Context;
using ECommerceAPI.Core;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Repositories.Concretes;
public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext) { }
}
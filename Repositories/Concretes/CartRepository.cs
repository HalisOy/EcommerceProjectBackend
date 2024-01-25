using ECommerceAPI.Context;
using ECommerceAPI.Core;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Repositories.Concretes;

public class CartRepository : BaseRepository<Cart>, ICartRepository
{
    public CartRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext) { }
}

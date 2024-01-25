using ECommerceAPI.Context;
using ECommerceAPI.Core;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Repositories.Concretes;

public class CartItemRepository : BaseRepository<CartItem>, ICartItemRepository
{
    public CartItemRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext) { }
}
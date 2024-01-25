using ECommerceAPI.Context;
using ECommerceAPI.Core;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Repositories.Concretes;

public class OrderRepository : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext) { }
}

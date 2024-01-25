using ECommerceAPI.Context;
using ECommerceAPI.Core;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Repositories.Concretes;

public class OrderCancelledRepository : BaseRepository<OrderCancelled>, IOrderCancelledRepository
{
    public OrderCancelledRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext) { }
}

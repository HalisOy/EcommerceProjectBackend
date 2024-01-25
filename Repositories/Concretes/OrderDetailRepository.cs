using ECommerceAPI.Context;
using ECommerceAPI.Core;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Repositories.Concretes;

public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext) { }
}
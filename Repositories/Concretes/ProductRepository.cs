using ECommerceAPI.Context;
using ECommerceAPI.Core;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Repositories.Concretes;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext) { }
}

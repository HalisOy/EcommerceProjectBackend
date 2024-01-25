using ECommerceAPI.Context;
using ECommerceAPI.Core;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Repositories.Concretes;

public class ProductCommentRepository : BaseRepository<ProductComment>, IProductCommentRepository
{
    public ProductCommentRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext) { }
}

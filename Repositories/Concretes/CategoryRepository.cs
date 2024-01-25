using ECommerceAPI.Context;
using ECommerceAPI.Core;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Abstracts;

namespace ECommerceAPI.Repositories.Concretes;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(ECommerceDbContext eCommerceDbContext) : base(eCommerceDbContext) { }
}
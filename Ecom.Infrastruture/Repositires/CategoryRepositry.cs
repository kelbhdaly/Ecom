using Ecom.Core.Entites.Product;
using Ecom.Core.Interfaces;
using Ecom.Infrastruture.Data.DbContexts;

namespace Ecom.Infrastruture.Repositires
{
    public class CategoryRepositry : GenaricRepositry<Category>, ICategoryRepositry
    {
        public CategoryRepositry(AppDbContext dbContext) : base(dbContext)
        {
        }


    }
}

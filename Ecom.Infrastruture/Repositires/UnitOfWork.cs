using Ecom.Core.Interfaces;
using Ecom.Infrastruture.Data.DbContexts;

namespace Ecom.Infrastruture.Repositires
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public IProductRepositry ProductRepositry { get; }

        public IPhotoRepositry PhotoRepositry { get; }

        public ICategoryRepositry CategoryRepositry { get; }
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            ProductRepositry = new ProductRepositry(_dbContext);
            PhotoRepositry = new PhotoRepositry(_dbContext);
            CategoryRepositry = new CategoryRepositry(_dbContext);

        }
    }
}

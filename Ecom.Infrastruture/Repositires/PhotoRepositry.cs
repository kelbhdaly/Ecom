using Ecom.Core.Entites.Product;
using Ecom.Core.Interfaces;
using Ecom.Infrastruture.Data.DbContexts;

namespace Ecom.Infrastruture.Repositires
{
    public class PhotoRepositry : GenaricRepositry<Photo>, IPhotoRepositry
    {
        public PhotoRepositry(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

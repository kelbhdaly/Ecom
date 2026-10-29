using Ecom.Core.Entites.Product;
using Ecom.Core.Interfaces;
using Ecom.Infrastruture.Data.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastruture.Repositires
{
    public class ProductRepositry : GenaricRepositry<Product>, IProductRepositry
    {
        public ProductRepositry(AppDbContext dbContext) : base(dbContext)
        {
        }

    }
}

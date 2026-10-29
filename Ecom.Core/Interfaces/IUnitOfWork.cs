using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Interfaces
{
    public interface IUnitOfWork
    {
        public IProductRepositry ProductRepositry { get; }

        public IPhotoRepositry PhotoRepositry { get; }

        public ICategoryRepositry CategoryRepositry { get; }
    }
}

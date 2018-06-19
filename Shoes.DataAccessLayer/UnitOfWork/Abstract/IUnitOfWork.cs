using Shoes.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DataAccessLayer.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        // Abstractllari cagir 
        ICategoryDal CategoryDal { get; }
        IBrandDal BrandDal { get; }
        ICarouselDal CarouselDal { get; }
        IProductDal ProductDal { get; }
        IProductSizeDal ProductSizeDal { get; }
        IRoleDal RoleDal { get; }
        ISizeDal SizeDal { get; }
        IUserDal UserDal { get; }

        // savechanges
        int Complete();
    }
}

using Shoes.DataAccessLayer.Abstract;
using Shoes.DataAccessLayer.Concrete;
using Shoes.DataAccessLayer.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DataAccessLayer.UnitOfWork.Concreate
{
    public class UnitOfWork_Class : IUnitOfWork
    {

        private ShoesDbContext _context;  // Dependecy Injection
        public UnitOfWork_Class(ShoesDbContext context)
        {
            _context = context;
            // 
            CategoryDal = new EfCategoryDal();
            BrandDal = new EfBrandDal();
            CarouselDal = new EfCarouselDal();
            ProductDal = new EfProductDal();
            ProductSizeDal = new EfProductSizeDal();
            RoleDal = new EfRoleDal();
            SizeDal = new EfSizeDal();
            UserDal = new EfUserDal();
        }


        public ICategoryDal CategoryDal { get; private set; }

        public IBrandDal BrandDal { get; private set; }

        public ICarouselDal CarouselDal { get; private set; }

        public IProductDal ProductDal { get; private set; }

        public IProductSizeDal ProductSizeDal { get; private set; }

        public IRoleDal RoleDal { get; private set; }

        public ISizeDal SizeDal { get; private set; }

        public IUserDal UserDal { get; private set; }
        /// <summary>
        /// Save Change cagrilacak!
        /// </summary>
        /// <returns></returns>
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

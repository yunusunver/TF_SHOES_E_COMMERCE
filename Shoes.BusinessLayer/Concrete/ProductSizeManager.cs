using Shoes.BusinessLayer.Abstract;
using Shoes.DataAccessLayer.Concrete;
using Shoes.DataAccessLayer.UnitOfWork.Abstract;
using Shoes.DataAccessLayer.UnitOfWork.Concreate;
using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BusinessLayer.Concrete
{
    public class ProductSizeManager : IProductSizeService
    {
        private IUnitOfWork _unitOfWork;

        public ProductSizeManager()
        {
            _unitOfWork = new UnitOfWork_Class(new ShoesDbContext());
        }

        public void Add(ProductSize productSize)
        {
            _unitOfWork.ProductSizeDal.Add(productSize);
            _unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            _unitOfWork.ProductSizeDal.Delete(new ProductSize { ProductSizeId=id});
            _unitOfWork.Complete();
        }

        public List<ProductSize> GetAll()
        {
            return _unitOfWork.ProductSizeDal.GetList();
        }

        public List<ProductSize> GetByProductSize(int id)
        {
            return _unitOfWork.ProductSizeDal.GetList(x=>x.ProductSizeId==id);
        }

        public void Update(ProductSize productSize)
        {
            _unitOfWork.ProductSizeDal.Update(productSize);
            _unitOfWork.Complete();
        }
    }
}

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
    public class ProductManager : IProductService
    {
        private IUnitOfWork _unitOfWork;

        public ProductManager()
        {
            _unitOfWork = new UnitOfWork_Class(new ShoesDbContext());
        }

        public void Add(Product product)
        {
            _unitOfWork.ProductDal.Add(product);
            _unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            _unitOfWork.ProductDal.Delete(new Product {ProductId=id });
            _unitOfWork.Complete();
        }

        public List<Product> GetAll()
        {
            return _unitOfWork.ProductDal.GetList();
        }

        public List<Product> GetByProduct(int id)
        {
            return _unitOfWork.ProductDal.GetList(x=>x.ProductId==id);
        }

        public void Update(Product product)
        {
            _unitOfWork.ProductDal.Update(product);
            _unitOfWork.Complete();
        }
    }
}

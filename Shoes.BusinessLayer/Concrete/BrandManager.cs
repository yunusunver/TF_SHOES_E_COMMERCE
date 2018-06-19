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
    public class BrandManager : IBrandService
    {
        private IUnitOfWork _unitOfWork;
        public BrandManager()
        {
            _unitOfWork = new UnitOfWork_Class(new ShoesDbContext());
        }

        public void Add(Brand brand)
        {
            // BrandDal

            _unitOfWork.BrandDal.Add(brand);
            _unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetByBrand()
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}

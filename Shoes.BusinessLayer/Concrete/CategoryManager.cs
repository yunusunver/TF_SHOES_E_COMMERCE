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
    public class CategoryManager :   ICategoryService
    {
        private IUnitOfWork _unitOfWork;

        public CategoryManager()
        {
            _unitOfWork = new UnitOfWork_Class(new ShoesDbContext());
        }
     
        public void Add(Category category)
        {
            _unitOfWork.CategoryDal.Add(category);
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetByCategory()
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }

    //public class BaseClass
    //{
    //    public IUnitOfWork _unitOfWork;
       
    //    public BaseClass()
    //    {
    //        _unitOfWork = new UnitOfWork_Class(new ShoesDbContext());
    //    }
    //}
}

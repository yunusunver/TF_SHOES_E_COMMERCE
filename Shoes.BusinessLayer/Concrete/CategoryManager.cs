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
            _unitOfWork.CategoryDal.Delete(new Category{CategoryId=id);
        }

        public List<Category> GetAll()
        {
            return _unitOfWork.CategoryDal.GetList();
        }

        public List<Category> GetByCategory(int id)
        {
            return _unitOfWork.CategoryDal.GetList(x=>x.CategoryId==id);
        }

        public void Update(Category category)
        {
            _unitOfWork.CategoryDal.Update(category);
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

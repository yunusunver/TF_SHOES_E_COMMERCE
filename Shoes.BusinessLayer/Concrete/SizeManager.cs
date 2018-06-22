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
    public class SizeManager : ISizeService
    {
        private IUnitOfWork _unitOfWork;

        public SizeManager()
        {
            _unitOfWork = new UnitOfWork_Class(new ShoesDbContext());
        }

        public void Add(Size size)
        {
            _unitOfWork.SizeDal.Add(size);
            _unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            _unitOfWork.SizeDal.Delete(new Size { SizeId=id});
            _unitOfWork.Complete();
        }

        public List<Size> GetAll()
        {
            return _unitOfWork.SizeDal.GetList();
        }

        public List<Size> GetBySize(int id)
        {
            return _unitOfWork.SizeDal.GetList(x=>x.SizeId==id);
        }

        public void Update(Size size)
        {
            _unitOfWork.SizeDal.Update(size);
            _unitOfWork.Complete();
        }
    }
}

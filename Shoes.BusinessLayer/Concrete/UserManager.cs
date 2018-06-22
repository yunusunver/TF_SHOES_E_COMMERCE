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
    public class UserManager : IUserService
    {
        private IUnitOfWork _unitOfWork;

        public UserManager()
        {
            _unitOfWork = new UnitOfWork_Class(new ShoesDbContext());
        }

        public void Add(User user)
        {
            _unitOfWork.UserDal.Add(user);
            _unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            _unitOfWork.UserDal.Delete(new User { UserId=id});
            _unitOfWork.Complete();
        }

        public List<User> GetAll()
        {
            return _unitOfWork.UserDal.GetList();
        }

        public List<User> GetByUser(int id)
        {
            return _unitOfWork.UserDal.GetList(x=>x.UserId==id);
        }

        public void Update(User user)
        {
            _unitOfWork.UserDal.Update(user);
            _unitOfWork.Complete();
        }
    }
}

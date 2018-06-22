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
    public class RoleManager : IRoleService
    {
        private IUnitOfWork _unitOfWork;

        public RoleManager()
        {
            _unitOfWork = new UnitOfWork_Class(new ShoesDbContext());
        }

        public void Add(Role role)
        {
            _unitOfWork.RoleDal.Add(role);
            _unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            _unitOfWork.RoleDal.Delete(new Role { RoleId = id });
            _unitOfWork.Complete();
        }

        public List<Role> GetAll()
        {
            return _unitOfWork.RoleDal.GetList();
        }

        public List<Role> GetByRole(int id)
        {
            return _unitOfWork.RoleDal.GetList(x=>x.RoleId==id);
        }

        public void Update(Role role)
        {
            _unitOfWork.RoleDal.Update(role);
            _unitOfWork.Complete();
        }
    }
}

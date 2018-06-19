using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BusinessLayer.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetByUser();
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}

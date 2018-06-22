using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BusinessLayer.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAll();
        List<Role> GetByRole(int id);
        void Add(Role role);
        void Update(Role role);
        void Delete(int id);
    }
}

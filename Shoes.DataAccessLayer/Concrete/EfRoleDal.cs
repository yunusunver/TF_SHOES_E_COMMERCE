using Shoes.CoreLayer.DataAccess.EntityFramework;
using Shoes.DataAccessLayer.Abstract;
using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DataAccessLayer.Concrete
{
    public class EfRoleDal: EfEntityRepositoryBase<Role,ShoesDbContext>,IRoleDal
    {
    }
}

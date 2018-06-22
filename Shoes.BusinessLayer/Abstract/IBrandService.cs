using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BusinessLayer.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetByBrand(int id);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(int id);
    }
}

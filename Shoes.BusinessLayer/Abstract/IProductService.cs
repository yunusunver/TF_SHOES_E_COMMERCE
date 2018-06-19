using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByProduct();
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}

using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BusinessLayer.Abstract
{
    public interface IProductSizeService
    {
        List<ProductSize> GetAll();
        List<ProductSize> GetByProductSize(int id);
        void Add(ProductSize productSize);
        void Update(ProductSize productSize);
        void Delete(int id);
    }
}

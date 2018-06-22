using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BusinessLayer.Abstract
{
    public interface ISizeService
    {
        List<Size> GetAll();
        List<Size> GetBySize(int id);
        void Add(Size size);
        void Update(Size size);
        void Delete(int id);
    }
}

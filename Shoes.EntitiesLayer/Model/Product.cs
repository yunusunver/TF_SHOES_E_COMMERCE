using Shoes.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.EntitiesLayer.Model
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public String Images { get; set; }

        // BrandName gelecek
        public double UnitPrice { get; set; }

        public int  UnitsInStock { get; set; }


    }
}

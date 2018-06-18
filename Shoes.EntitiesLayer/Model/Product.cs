using Shoes.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.EntitiesLayer.Model
{
    public class Product:IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public String Images { get; set; }

        // BrandName gelecek
        public double UnitPrice { get; set; }

        public int  UnitsInStock { get; set; }

        // Bir ürünün bir tane categorisi olur 
        public int CategoryId { get; set; }
       
        public virtual Category Category { get; set; } // Navigation prop

        // Bir ürünün birden fazla  size'i olur 
        public virtual List<Size> Sizes { get; set; }

        public Product()
        {
            Sizes = new List<Size>();
        }

    }
}

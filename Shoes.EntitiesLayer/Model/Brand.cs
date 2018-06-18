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
    public class Brand:IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }

        public String BrandName { get; set; }

        public String Icon { get; set; }

        // Bir markanın birden fazla ürünü olur 
        public virtual List<Product> Products  { get; set; }

        public Brand()
        {
            Products = new List<Product>();
        }
    }
}

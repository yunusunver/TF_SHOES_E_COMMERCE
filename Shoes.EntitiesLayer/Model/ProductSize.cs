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
    public class ProductSize:IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductSizeId { get; set; }
        // Product ve Size gelecek!
        public int ProductId { get; set; }
        public int SizeId { get; set; }

        public virtual Product Product { get; set; } // Navigaiton prop
        public virtual Size Size { get; set; } // Navigation prop

    }
}

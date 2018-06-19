using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DataAccessLayer.Concrete
{
    public class ShoesDbContext:DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Carousel> Caraousels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Size> Sizes{ get; set; }
        public DbSet<User> Users { get; set; }
    }
}

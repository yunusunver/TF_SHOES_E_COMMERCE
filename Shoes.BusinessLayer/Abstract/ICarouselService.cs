using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BusinessLayer.Abstract
{
    public interface ICarouselService
    {
        List<Carousel> GetAll();
        List<Carousel> GetByCarousel(int id);
        void Add(Carousel carousel);
        void Update(Carousel carousel);
        void Delete(int id);
    }
}

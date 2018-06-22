using Shoes.BusinessLayer.Abstract;
using Shoes.DataAccessLayer.Concrete;
using Shoes.DataAccessLayer.UnitOfWork.Abstract;
using Shoes.DataAccessLayer.UnitOfWork.Concreate;
using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BusinessLayer.Concrete
{
    public class CarouselManager : ICarouselService
    {
        private IUnitOfWork _unitOfWork;

        public CarouselManager()
        {
            _unitOfWork = new UnitOfWork_Class(new ShoesDbContext());
        }

        public void Add(Carousel carousel)
        {
            _unitOfWork.CarouselDal.Add(carousel);
            _unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            _unitOfWork.CarouselDal.Delete(new Carousel { CarouselId=id});
            _unitOfWork.Complete();
        }

        public List<Carousel> GetAll()
        {
            return _unitOfWork.CarouselDal.GetList();
        }

        public List<Carousel> GetByCarousel(int id)
        {
            return _unitOfWork.CarouselDal.GetList(x=>x.CarouselId==id);
        }

        public void Update(Carousel carousel)
        {
            _unitOfWork.CarouselDal.Update(carousel);
            _unitOfWork.Complete();

        }
    }
}

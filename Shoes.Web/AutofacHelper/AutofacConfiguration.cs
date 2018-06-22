using Autofac;
using Autofac.Integration.Mvc;
using Shoes.BusinessLayer.Abstract;
using Shoes.BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Shoes.Web.AutofacHelper
{
    public class AutofacConfiguration
    {

        public static void Config()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<CarouselManager>().As<ICarouselService>();
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<ProductSizeManager>().As<IProductSizeService>();
            builder.RegisterType<RoleManager>().As<IRoleService>();
            builder.RegisterType<SizeManager>().As<ISizeService>();
            builder.RegisterType<UserManager>().As<IUserService>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

    }
}
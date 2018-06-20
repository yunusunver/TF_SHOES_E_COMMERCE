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
    public static class AutofacConfiguration
    {
        public static void Config()
        {
            // autofac ayalrıar 
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // classa cevir
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<RoleManager>().As<IRoleService>();
            // hepsini yaz
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
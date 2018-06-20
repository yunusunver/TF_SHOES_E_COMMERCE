using Shoes.BusinessLayer.Abstract;
using Shoes.EntitiesLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shoes.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryService service;
        private IRoleService roleService;
        public HomeController(ICategoryService service,IRoleService roleService)
        {
            this.service = service;
            this.roleService = roleService;
        }

        public ActionResult Index()
        {
             List<Category> list =  service.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
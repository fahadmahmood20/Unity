using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityDIMVC.Repositories;

namespace UnityDIMVC.Controllers
{
    public class HomeController : Controller
    {
        readonly IProductRepository _productRepository; 

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository; 
        }
        public ActionResult Index()
        {
            var product = _productRepository.GetProduct(1);
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
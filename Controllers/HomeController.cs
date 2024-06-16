using Microsoft.AspNetCore.Mvc;
using PractikaVovk.Data.Interfaces;
using PractikaVovk.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProducts _allProducts;
        
        public HomeController(IProducts iProducts)
        {
            _allProducts = iProducts;
            
        }
        public ViewResult Index()
        {
            ViewBag.Title = "Home page";
            ListElectricalModel obj = new ListElectricalModel(); 
            obj.getIAllElectrical = _allProducts.IAllElectrical;
            obj.getIAllCategory = "Category";//_allCategory.IAllCategory;
            return View(obj);
        }       
    }
}

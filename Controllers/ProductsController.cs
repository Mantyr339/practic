using Microsoft.AspNetCore.Mvc;
using PractikaVovk.Data.Interfaces;
using PractikaVovk.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProducts _allProducts;
        private readonly ICategory _allCategory;
        public ProductsController(IProducts iProducts, ICategory icategories)
        {
            _allProducts = iProducts;
            _allCategory = icategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Page with Electrical";
            ListElectricalModel obj = new ListElectricalModel(); 
            obj.getIAllElectrical = _allProducts.IAllElectrical;
            obj.getIAllCategory = "Category";//_allCategory.IAllCategory;
            return View(obj);
        }       
    }
}

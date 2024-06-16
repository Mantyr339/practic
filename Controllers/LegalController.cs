using Microsoft.AspNetCore.Mvc;
using PractikaVovk.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Controllers
{
    public class LegalController : Controller
    {
        private readonly ILegal _allLegal;
        public LegalController(ILegal ilegal)
        {
         _allLegal = ilegal;
        }
         public ViewResult List()
         {
            var Prod = _allLegal.IAllLegal;
            return View(Prod);
         }
    }
}

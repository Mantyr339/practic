using Microsoft.AspNetCore.Mvc;
using PractikaVovk.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Controllers
{
    public class IndividualController : Controller
    {
        private readonly IIndividual _allIndividual;
         public IndividualController(IIndividual iIndividual)
         {
            _allIndividual = iIndividual;
         }
        public ViewResult List()
        {
            var Prod = _allIndividual.IAllIndividual;
            return View(Prod);
        }
    
    }
}

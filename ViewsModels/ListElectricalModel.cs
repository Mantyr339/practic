using PractikaVovk.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.ViewsModels
{
    public class ListElectricalModel
    {
        public IEnumerable<Electrical> getIAllElectrical { set; get; }

        public string getIAllCategory { get; set; }
    }
}

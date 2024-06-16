using PractikaVovk.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Data.Interfaces
{
    public interface IProducts
    {
        IEnumerable<Electrical> IAllElectrical { get; }
        IEnumerable<Electrical> IAllFavourite { set; get; }
        Electrical IElectrical(int prog);
       
    }
}

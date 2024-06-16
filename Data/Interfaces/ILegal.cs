using PractikaVovk.Data.Models.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Data.Interfaces
{
    public interface ILegal
    {
        IEnumerable<Legal> IAllLegal { get; }
    }
}

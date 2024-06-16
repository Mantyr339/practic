using PractikaVovk.Data.Interfaces;
using PractikaVovk.Data.Models.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Data.Mocks
{
    public class MockILegal : ILegal
    {
        public IEnumerable<Legal> IAllLegal            
        {
            get
            {
                return new List<Legal>
                {
                        new Legal {namePerson ="Eva" ,status  ="постачальник"},
                        new Legal {namePerson ="Paul" ,status  ="постачальник"}
                };
            }
        }
    }
}

using PractikaVovk.Data.Interfaces;
using PractikaVovk.Data.Models.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Data.Mocks
{
    public class MockIIndividual : IIndividual
    {
        public IEnumerable<Individual> IAllIndividual
        {
            get
            {
                return new List<Individual>
                {
                        new Individual {namePerson ="Eva" , surnamePerson ="Roberts"},
                        new Individual {namePerson ="Paul" , surnamePerson ="Tomson"}
                };
            }
        }
    }
}

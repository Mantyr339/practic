using PractikaVovk.Data.Interfaces;
using PractikaVovk.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Data.Mocks
{
    public class MockICategory : ICategory
    {
        public IEnumerable<Category> IAllCategory 
        {
            get
            {
                return new List<Category>
                {
                        new Category 
                        {
                            name ="Електротехніка" , 
                            desc ="Пов'язані з проведенням, накопиченням і прийомом електроенергії",
                            img =@"\Img\Shyrypovert.jpg"
                        },
                        new Category
                        {
                            name ="Електроінструмунти" ,
                            desc ="механизированный инструмент, у которого приводным двигателем является электродвигатель",
                            img =@"\Img\Shyrypovert.jpg"
                        }
                };
            }
        }
        public Category ICategory(int prog)
        {
            throw new NotImplementedException();
        }
    }
}

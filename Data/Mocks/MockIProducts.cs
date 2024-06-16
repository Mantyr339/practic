using PractikaVovk.Data.Interfaces;
using PractikaVovk.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PractikaVovk.Data.Mocks
{
    public class MockIProducts : IProducts
    {
        private readonly ICategory _categoryElectrical = new MockICategory();
        public IEnumerable<Electrical> IAllElectrical   
        {
            get
            {
                return new List<Electrical>
                {
                    new Electrical{
                        name ="Аккумуляторный шуруповерт Makita 330",
                        brand ="Makita",
                        id=1,
                        available = 200,
                        firstСost = 1000,
                        provider = "IEK",
                        shortDesc = "Аккумуляторный шуруповерт Makita 330 DWE (12V, 2AH) с набором. Шуруповёрт Макита, дрель шуруповерт 3",
                        img =@"\Img\Shyrypovert.jpg"   ,
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                    new Electrical{
                        name ="Аккумуляторный perforator Makita 330",
                        brand ="Makita",
                        id=2,
                        available = 200,
                        firstСost = 2974,
                        provider = "IEK",
                        shortDesc = "Aккумуляторный perforator Makita 330",
                        img =@"\Img\Perf.jpg",
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                    new Electrical{
                        name ="Шліфмашина кутова Dnipro-M GL-125S",
                        brand ="Makita",
                        id=3,
                        available = 200,
                        firstСost = 2287,
                        provider = "IEK",
                        shortDesc = "Шліфмашина кутова Dnipro-M GL-125S",
                        img =@"\Img\thumb.jpg",
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                    new Electrical{
                        name ="Лобзик електричний Dnipro-M JS-65LX",
                        brand ="Makita",
                        id=4,
                        available = 200,
                        firstСost = 4823,
                        provider = "IEK",
                        shortDesc = "Лобзик електричний Dnipro-M JS-65LX",
                        img =@"\Img\lobz.jpg",
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                    new Electrical{
                        name ="Фрезер Dnipro-M ЕR-160S",
                        brand ="Makita",
                        id=5,
                        available = 200,
                        firstСost = 1579,
                        provider = "IEK",
                        shortDesc = "dfsadaadasdasdasdaw",
                        img =@"\Img\frezer.jpg",
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                    new Electrical{
                        name ="Шліфмашина вібраційна Dnipro-M PS-30S",
                        brand ="Makita",
                        id=6,
                        available = 200,
                        firstСost = 2534,
                        provider = "IEK",
                        shortDesc = "Шліфмашина вібраційна Dnipro-M PS-30S",
                        img =@"\Img\shlif.jpg",
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                    new Electrical{
                        name ="Міксер будівельний Dnipro-M BM-162S",
                        brand ="Makita",
                        id=7,
                        available = 200,
                        firstСost = 1315,
                        provider = "IEK",
                        shortDesc = "Міксер будівельний Dnipro-M BM-162S",
                        img =@"\Img\mix.jpg",
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                    new Electrical{
                        name ="Циркулярна пила Dnipro-M CS-235 IN",
                        brand ="Makita",
                        id=8,
                        available = 200,
                        firstСost = 1311,
                        provider = "IEK",
                        shortDesc = "Циркулярна пила Dnipro-M CS-235 IN",
                        img =@"\Img\cer.jpg",
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                    new Electrical{
                        name ="Фарбопульт електричний Dnipro-M SH-65",
                        brand ="Makita",
                        id=9,
                        available = 200,
                        firstСost = 5671,
                        provider = "IEK",
                        shortDesc = "Фарбопульт електричний Dnipro-M SH-65",
                        img =@"\Img\farb.jpg",
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                     new Electrical{
                        name ="Аккумуляторный perforator Makita 330",
                        brand ="Makita",
                        id=10,
                        available = 200,
                        firstСost = 1234,
                        provider = "IEK",
                        shortDesc = "Аккумуляторный шуруповерт Makita 330 DWE (12V, 2AH) с набором. Шуруповёрт Макита, дрель шуруповерт 3",
                        img =@"\Img\Perf.jpg",
                        isFavourite = true,
                        Category =_categoryElectrical.IAllCategory.First()
                    },
                };
            }
        }
        public IEnumerable<Electrical> IAllFavourite { get ; set ; }

        public Electrical IElectrical(int prog)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Data.Models.Provider
{
    public class Individual
    {
        public string namePerson { set; get; }
        public string surnamePerson { set; get; }
        public string status { set; get; }
        public int contactInfo { set; get; }
        public string name { set; get; }
        public int quantity { set; get; }
        // Количество товару
        public int cost { set; get; }
        public string payment { set; get; }
        //Спомоб оплаты

    }
}

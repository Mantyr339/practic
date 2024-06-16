using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Data.Models
{
    public class Electrical
    {
        public int id { set; get; }
        public string name { set; get; }
        public string brand { set; get; }
        public int available { set; get; }
        //наявна кількість
        public ushort firstСost { set; get; }
        //закупівельна вартість одиниці товару
        public string provider { set; get; }
        //постачальник
        public string shortDesc { set; get; }
        //короткое описание
        public string img { set; get; }
        public bool isFavourite { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }





    }
}

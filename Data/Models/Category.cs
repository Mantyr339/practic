using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractikaVovk.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string name { set; get; }
        public string desc { set; get; }
        public string img { set; get; }
        public List<Electrical> Electricals { set; get; }
    }
}

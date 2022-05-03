using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models

{
    public class Discount
    {
        public int id { get; set; }
        public string schemename { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public string application { get; set; }
        public string productlist { get; set; }
        public double discountvalue { get; set; }
        public string discounttype { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class Sale
    {
        public int id { get; set; }
        public string customerID { get; set; }
        public double totalValue { get; set; }
        public DateTime date { get; set; }
        public double packingcharges { get; set; }
        public double GST { get; set; }
        public double discount { get; set; }
        public string modeofpayment { get; set; }
    }
}

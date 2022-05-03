using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class ProducsSold
    {
        public int id { get; set; }
        [ForeignKey("Sale")]
        public int SaleID { get; set; }
        public Sale Sale { get; set; }
        [ForeignKey("Food")]
        public int FoodID { get; set; }
        public Food Food { get; set; }
        public double quantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime date { get; set; }
    }
}

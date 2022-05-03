using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class Cart
    {
        public int id { get; set; }
        public string customerID { get; set; }
        [ForeignKey("Food")]
        public int FoodID { get; set; }
        public Food Food { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public double quantity { get; set; }
        public double price { get; set; }
        public DateTime date { get; set; }

    }
}

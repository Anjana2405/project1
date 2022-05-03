using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class Inventory
    {
        public int id { get; set; }
        [ForeignKey("Food")]
        public int FoodID { get; set; }
        public Food Food { get; set; }
        public double quantity { get; set; }
        public int reorderlevel { get; set; }
        public DateTime datetimesampe { get; set; }
      

    }
}


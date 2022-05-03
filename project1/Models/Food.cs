using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class Food
    {
        public int id { get; set; }
        [ForeignKey("Category")]

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public string Foodname { get; set; }
        public double price { get; set; }
        public string description { get; set; }
    }
}

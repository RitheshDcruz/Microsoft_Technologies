using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore1.Models
{
    public class Product
    {

        public int ProductID { get; set; }
        [Required (ErrorMessage="Enter a product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter a product Description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01,double.MaxValue,ErrorMessage = "Enter a positive price")]
        public decimal  Price { get; set; }
        [Required(ErrorMessage = "Enter a product Category")]
        public string Category { get; set; }



    }
}

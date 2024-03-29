﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore1.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [Required(ErrorMessage="Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a the first line of address")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }

        [BindNever]
        public bool Shipped { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a Country")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }






















    }
}

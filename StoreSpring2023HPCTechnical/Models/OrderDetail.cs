﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSpring2023HPCTechnical.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        

        public Order Orders { get; set; } = null!;
        public Product Products { get; set; } = null!;
        public override string? ToString()
        {
            return $"\tQty:\t{Quantity}\n\tProduct Name:\t{Products.Name}\n\tPrice:\t{Products.Price}";
        }
    }
}

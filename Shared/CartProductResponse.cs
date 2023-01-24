﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Shared
{
    public class CartProductResponse
    {
        public int ProductId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ProductTypeID { get; set; }
        public string ProductType { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }


    }
}

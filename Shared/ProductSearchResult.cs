﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Shared
{
    public class ProductSearchResult
    {
        public List<Product> Products { get; set;} = new List<Product>();
        public int Pages { get; set;}
        public int currentPage { get; set;}

    }
}

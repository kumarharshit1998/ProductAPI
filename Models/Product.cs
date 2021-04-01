﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int QtyInStock{ get; set; }
        public String Description { get; set; }
        public String Supplier { get; set; }
    }
}
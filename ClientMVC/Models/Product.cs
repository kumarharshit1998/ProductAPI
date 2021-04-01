using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientMVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int QtyInStock { get; set; }

        public string Description { get; set; }

        public string Supplier { get; set; }
    }
}
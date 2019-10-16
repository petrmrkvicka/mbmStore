using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore2.Models
{
    public class Product
    {
        // fields


        // properties
        public int ProductId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string Category { get; set; }





        // constructors

        public Product(){}


        public Product(int productId, string title, decimal price)
        {
            ProductId = productId;
            Price = price;
            Title = title;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore2.Models
{
    public class OrderItem
    {
        // fields
        private decimal totalPrice;


        // properties
        public int OrderItemId
        {
            get; set;
        }

        public int ProductId
        {
            get; set; 
        }

        public Product Product
        {
            get; set; 
        }

        public int Quantity
        {
            get; set;
        }

        public decimal TotalPrice
        {
            get
            {
                totalPrice = Product.Price * Quantity;

                return totalPrice;
            }
        }


        // constructors

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

    }
}
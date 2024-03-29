﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore2.Models
{
    public class Invoice
    {
        // fields
        private decimal totalPrice;


        // properties
        public int InvoiceId
        {
            get; set;
        }

        public DateTime OrderDate
        {
            get; set;
        }

        public decimal TotalPrice
        {
            get
            {
                foreach (OrderItem item in OrderItems)
                {
                    totalPrice += item.Product.Price * item.Quantity;
                }

                return totalPrice;
            } 
        }

        public Customer Customer
        {
            get; set;
        }

        public List<OrderItem> OrderItems
        {
            get; set;
        } = new List<OrderItem>();



        // constructors

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }

        public void AddOrderItem(Product product, int quantity)
        {
            OrderItems.Add(new OrderItem(product, quantity));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using MbmStore2.Models;

namespace MbmStore2.Models.ViewModels
{
    public class Cart
    {

        private List<CartLine> lineCollection = new List<CartLine>();

        public decimal TotalPrice
        {
            get;
        }

        public List<CartLine> Lines
        {
            get
            {
                return lineCollection;
            }
        }


        public virtual void AddItem(Product product, int quantity)
        {
            CartLine item = lineCollection
                .Where(p => p.Product.ProductId == product.ProductId)
                .FirstOrDefault();

            if(item == null)
            {
                lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                item.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product) =>
            lineCollection.RemoveAll(i => i.Product.ProductId == product.ProductId);

        public decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Product.Price * e.Quantity);

        public virtual void Clear() => lineCollection.Clear();


        public Cart()
        {
        }



    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

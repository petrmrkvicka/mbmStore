using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore2.Models
{
    public class Book : Product
    {
        // fields


        // properties
        public string Author
        {
            get; set;
        }

        public string Publisher
        {
            get; set;
        }

        public short Published
        {
            get; set;
        }

        public string ISBN
        {
            get; set;
        }





        // constructors


        public Book(int productId, string author, string title, decimal price, short published) : base(productId, title, price)
        {
            Author = author;
            Published = published;
        }
    }
}

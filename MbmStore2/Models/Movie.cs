using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore2.Models
{
    public class Movie : Product
    {
        // fields
       
        // properties
        public string Director
        {
            get; set;
        }

        public short Released
        {
            get; set;
        }

        // constructors
        public Movie(int productId, string title, decimal price) : base(productId, title, price)
        {
        }
    }
}
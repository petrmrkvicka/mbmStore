﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
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
        public Movie(string title, decimal price) : base(title, price)
        {
        }
    }
}
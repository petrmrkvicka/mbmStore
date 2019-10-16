using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore2.Models
{
	public class Track
	{
        // fields


        // properties
        public string Title
        {
            get; set;
        }

        public string Composers
        {
            get; set;
        }


		public TimeSpan Length
		{
	    	get; set;
		}




		// constructors


		public Track() { }
		public Track(string title, TimeSpan length)
		{
			Title = title;
            Length = length;
		}

	}
}

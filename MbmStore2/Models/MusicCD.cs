using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore2.Models
{
    public class MusicCD : Product
    {
        // fields
        //private TimeSpan length;
        public List<string> composer;

        // properties
        public List<Track> Tracks { get; } = new List<Track>();

        public string Artist
        {
            get; set;
        }

        public string Label
        {
            get; set;
        }

        public short Released
        {
            get; set;
        }

        public TimeSpan PlayingTime
        {
            get
            {
                TimeSpan totalTime = new TimeSpan();
                foreach (Track tr in Tracks)
                {
                    totalTime += tr.Length;
                }
                return totalTime;
            }
        } 
        

        // constructors
        public MusicCD(int productId, string artist, string title, decimal price, short released) : base(productId, title, price)
        {
            Artist = artist;
            Released = released;
        }


        // method
        public void AddTrack(string title, List<string> composer, TimeSpan length)
        {
            Track track = new Track(title, length)
            {
                Composers = string.Join(", ", composer)
            };
            Tracks.Add(track);
            //PlayingTime = PlayingTime + length;
            //Console.WriteLine("this");
        }



      
    }
}

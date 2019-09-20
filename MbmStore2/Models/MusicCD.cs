using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
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
            get; set; // Can't make it read-only!!!!
            /*{
                foreach(Track track in Tracks)
                {
                    PlayingTime.Add(track.Length);
                    Console.WriteLine(PlayingTime);
                }
                return PlayingTime;
            }*/
        } 
        

        // constructors
        public MusicCD(string artist, string title, decimal price, short released) : base(title, price)
        {
            Artist = artist;
            Title = title;
            Price = price;
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
            PlayingTime = PlayingTime + length;
            Console.WriteLine("this");
        }



      
    }
}

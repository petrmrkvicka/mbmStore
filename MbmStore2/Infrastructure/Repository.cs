using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public static class Repository
    {
        // fields

        // properties
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();







        // constructors
        static Repository(){



            ////////
            // Books
            ////////

            Book b1 = new Book("Steve Turner", "A hard day's write", 150M, 2005)
            {
                Publisher = "It Books",
                ISBN = "9781858680330",
                ImageUrl = "a-hard-days-write.jpg"
            };
            Products.Add(b1);

            Book b2 = new Book("William Pearson", "With a Little Help from My Friends: The Making of Sgt. Pepper", 1800, 1995)
            {
                Publisher = "Little Brown & Co",
                ISBN = "978-0316547833",
                ImageUrl = "little-help.jpg"
            };
            Products.Add(b2);




            ////////
            // Music CDs
            ////////

            MusicCD cd1 = new MusicCD("The Beatles", "Abbey Road (Remastered)", 128M, 2009)
            {
                Label = "EMI",
                ImageUrl = "abbey-road.jpg"
            };
            cd1.AddTrack("Come Together", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Something", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Maxwell's Silver Hammer", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Oh! Darling", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Octopus' Garden", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("I Want You (She's So Heavy)", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Here Comes The Sun", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Because", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("You Never Give Me Your Money", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Sun King", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Mean Mr. Mustard", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Polythene Pam", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("She Came In Through The Bathroom Window", new List<string>() { }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Golden Slumbers", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Carry That Weight", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("The End", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            cd1.AddTrack("Her Majesty", new List<string>() { "" }, new TimeSpan(0, 0, 0));
            Products.Add(cd1);

            MusicCD cd2 = new MusicCD("The Beatles", "Revolver (Remastered)", 128M, 2009)
            {
                Label = "EMI",
                ImageUrl = "revolver.jpg"
            };
            cd2.AddTrack("Taxman", new List<string>() { "Harrisson" }, new TimeSpan(0, 2, 28));
            cd2.AddTrack("Eleanor Rigby", new List<string>() { "Lennon", "McCartney" }, new TimeSpan(0, 2, 6));
            cd2.AddTrack("I'm Only Sleeping", new List<string>() { "Lennon", "McCartney" }, new TimeSpan(0, 3, 0));
            cd2.AddTrack("Love You Too", new List<string>() { }, new TimeSpan(0, 2, 59));
            cd2.AddTrack("Here, There and Everywhere", new List<string>() { }, new TimeSpan(0, 2, 23));
            cd2.AddTrack("Yellow Submarine", new List<string>() { }, new TimeSpan(0, 2, 38));
            cd2.AddTrack("She Said She Said", new List<string>() { }, new TimeSpan(0, 2, 36));
            cd2.AddTrack("Good Day Sunshine", new List<string>() { }, new TimeSpan(0, 2, 09));
            cd2.AddTrack("And Your Bird Can Sing", new List<string>() { }, new TimeSpan(0, 2, 0));
            cd2.AddTrack("For No One", new List<string>() { }, new TimeSpan(0, 1, 59));
            cd2.AddTrack("Doctor Robert", new List<string>() { }, new TimeSpan(0, 2, 14));
            cd2.AddTrack("I Want To Tell You", new List<string>() { }, new TimeSpan(0, 2, 27));
            cd2.AddTrack("Got To Get You Into My Life", new List<string>() { }, new TimeSpan(0, 2, 29));
            cd2.AddTrack("Tomorrow Never Knows", new List<string>() { }, new TimeSpan(0, 3, 01));
            Products.Add(cd2);




            ////////
            // Movies
            ////////
           
            Movie jungleBook = new Movie("Jungle Book", 160.50m)
            {
                ImageUrl = "junglebook.jpg",
                Director = "Jon Favreau"
            };
            Products.Add(jungleBook);

            Movie johnWick3 = new Movie("John Wick 3", 75m)
            {
                ImageUrl = "jw.jpg",
                Director = "Chad Stahelski"
            };
            Products.Add(johnWick3);

            Movie it2 = new Movie("It 2", 60m)
            {
                ImageUrl = "it.jpg",
                Director = "Andrés Muschietti"
            };
            Products.Add(it2);




            ////////
            // Invoices
            ////////
            // Customers

            Customer cust1 = new Customer(0, "Petr", "Mrkvicka", "Vestervang 10", "8000", "Aarhus C");
            cust1.AddPhoneNumber("91887697");
            cust1.AddPhoneNumber("74882938");
            cust1.BirthDate = new DateTime(1997, 11, 26);

            Customer cust2 = new Customer(1, "Martina", "Mesopotama", "Oreostrasse 22", "840123", "Mezmez");
            cust2.AddPhoneNumber("83339202");
            cust2.BirthDate = new DateTime(1997, 11, 26);

            Customer cust3 = new Customer(2, "John", "Doe", "Notting Hill 12", "19291", "London");
            cust3.AddPhoneNumber("74939393");
            cust3.BirthDate = new DateTime(1997, 11, 26);


            // Invoices

            Invoice inv1 = new Invoice(0, new DateTime(2019, 09, 04), cust1);
            inv1.AddOrderItem(cd2, 2);
            Invoices.Add(inv1);

            Invoice inv2 = new Invoice(0, new DateTime(2019, 09, 13), cust3);
            inv2.AddOrderItem(johnWick3, 1);
            inv2.AddOrderItem(b2, 1);
            Invoices.Add(inv2);

            Invoice inv3 = new Invoice(0, new DateTime(2019, 09, 16), cust2);
            inv3.AddOrderItem(it2, 2);
            inv3.AddOrderItem(cd1, 1);
            inv3.AddOrderItem(b1, 2);
            Invoices.Add(inv3);




        }



    }
}

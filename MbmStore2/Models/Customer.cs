using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        // fields
        private DateTime birthDate;

        // properties
        public int CustomerId
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public string Zip
        {
            get; set;
        }

        public string City
        {
            get; set;
        }

        public List<string> PhoneNumbers { get; } = new List<string>();

        public DateTime BirthDate
        {
            set
            {
                if (value > DateTime.Today.AddYears(-2))
                {
                    throw new Exception("At least one of the customers is too young");
                }
                if (value < DateTime.Today.AddYears(-120))
                {
                    throw new Exception("At least one of the customers is too old");
                }
                else
                {
                    birthDate = value;
                }
            }
            get { return birthDate; }
        }
     
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;

                age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
            }

        }

        public List<Invoice> Invoices
        {
            get; set;
        }

        



        // constructors


        public Customer(int customerId, string firstname, string lastname, string address, string zip, string city )
        {
            CustomerId = customerId;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Zip = zip;
            City = city;
        }

        public void AddPhoneNumber(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
        
    }
}

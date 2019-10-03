using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MbmStore2.Controllers
{
    public class InvoiceController : Controller
    {
        List<SelectListItem> customers = new List<SelectListItem>();
        List<Invoice> invoices = new List<Invoice>();

        [HttpPost]
        public IActionResult Index(int? customer)
        {
            foreach (Invoice invoice in Repository.Invoices)
            {
                if(invoice.Customer.CustomerId == customer)
                {
                    customers.Add(new SelectListItem { Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName, Value = invoice.Customer.CustomerId.ToString(), Selected = true });

                } else {
                    customers.Add(new SelectListItem { Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName, Value = invoice.Customer.CustomerId.ToString() });
                }

                if(customer != null)
                {
                    invoices = Repository.Invoices.Where(r => r.Customer.CustomerId==customer).ToList();
                    ViewBag.Invoices = invoices;
                } else
                {
                    ViewBag.Invoices = Repository.Invoices;
                }

            }

            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            ViewData["Customers"] = customers;

            return View();

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem { Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName, Value = invoice.Customer.CustomerId.ToString() });
            }

            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            ViewBag.Invoices = Repository.Invoices;
            ViewData["Customers"] = customers;

            return View();
        }
    }
}

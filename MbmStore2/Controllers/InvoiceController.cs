using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MbmStore2.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.Invoices = Repository.Invoices;

            return View();
        }
    }
}

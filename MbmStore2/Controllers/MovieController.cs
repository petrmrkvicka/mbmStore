using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore2.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>();

            // create a new Movie object with instance name jungleBook


            // assign a viewbag property to the new Movie object
            ViewBag.Movies = movies;
            return View();
        }
    }
}
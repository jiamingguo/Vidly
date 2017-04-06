using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
            // here the return type is ActionResult. It could be other types if necessary.
        {
            var movie = new Movie(){ Name = "Shrek!"};

            return View(movie);

        }
    }
}
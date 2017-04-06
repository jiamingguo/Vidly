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

            // return Content("HelloWorld");
            // return HttpNotFound();
            // return RedirectToAction("Index", "Home", new {page = 1,sortBy = "name" }); // redirect to home page


            return View();

        }

        // GET: movies/edit/#id 
        // Also: movie/edit?id=1
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
        
        // the '?' after "int" means Nullable. 
        // string is a reference type, it could be null. int is a value type, it shouldn't be null.
        // here we just want to make it nullalbe so the function can handle multiple cases
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex = {0}&sortBy{1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/test/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult AttributeRouteTest(int year, int month)
        {
            return Content("Test Attribute Route" + year + "/" + month);
        }
    }
}
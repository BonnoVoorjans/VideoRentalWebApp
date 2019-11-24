using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental.Models;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() {Name = "Shrek", Id = 2, RentalPrice = 5.50};
            return View(movie);

            /*Verschillende soorten ActionResults met helper method:
             * ViewResult - View()
             * PartialViewResult - PartiealView()
             * ContentResult - Content()
             * RedirectResult - Redirect()
             * RedirectToRouteResult - RedirectToAction() de redirect kan inclusief parameters: RedirectToAction("Index", "Home", new {page = 1, sortBy = "name asc"});
             * JsonResult - Json()
             * FileResult - File()
             * HttpNotFoundResult - HttpNotFound()
             * EmptyResult (like void) - no helper 
             */
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id); 
        }

        public ActionResult Index(int? pageIndex, string sortBy) // int? toont aan dat de parameter optioneel is. Hierdoor kan HasValue gebruikt worden op de parameter.
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult getMoviesByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }
    }
}
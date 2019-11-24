using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VideoRental
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(      //Op deze manier kan een custom route gemaakt worden. Dit moet voor de default komen. Je werkt van specifiek naar globaal toe.
                name: "MoviesByReleaseDate",
                url: "movies/released/{year}/{month}",
                new { controller = "Movies", action = "getMoviesByReleaseDate"},
                new { year = @"\d{4}", month = @"\d{2}" });
               //new {year = @"2015|2016", month = @"\d{2}"}); om jaren enkel voor 2015 en 2016 toe te staan.

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", //Standaard routes bevatten een controller naam, een action (methode van een controller) en een attribuut id. 
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

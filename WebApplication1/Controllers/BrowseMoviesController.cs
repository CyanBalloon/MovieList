using MvcMovie.omdbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MvcMovie.Controllers
{
    public class BrowseMoviesController : Controller
    {
        //
        // GET: /BrowseMovies/
        public ActionResult Index()
        {
            omdbClass.omdbClass.Instance.addSearchCommand(new searchByTitleCommand("American Psycho"));
            List<Models.omdbMovie> moviesList = omdbClass.omdbClass.Instance.executeSearch();

            return View(moviesList);
        } 
        
        //
        // POST: /BrowseMovies/
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            string searchStr = Request["searchMovies"];

            omdbClass.omdbClass.Instance.addSearchCommand(new searchByTitleCommand(searchStr));
            List<Models.omdbMovie> moviesList = omdbClass.omdbClass.Instance.executeSearch();

            return View(moviesList);
        }

        public ActionResult GlobalVariables()
        {
            var globalVariables = typeof(GlobalVariables)
                .GetFields()
                .ToDictionary(x => x.Name, x => x.GetValue(null));
            var json = new JavaScriptSerializer().Serialize(globalVariables);
            return JavaScript("var globalVariables = " + json + ";");
        }

        //
        // GET: /BrowseMovies/Search/5
        public ActionResult Search(int id)
        {
            return View();
        }
    }
}

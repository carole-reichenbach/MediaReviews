
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaReviews.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        // GET: /Home/Welcome
        public ViewResult Welcome()
        {
            // A method in the controller gets the data for the page and decides what kind of page

            // create a class that has the data for the page            

            // create an instance of that class and set the data
            WelcomeData data = new WelcomeData();
            data.Message = "Welcome";

            // pass the data to the view and return it
            return View(data);

        }
    }

    public class WelcomeData
    {
        public string Message;
    }

}

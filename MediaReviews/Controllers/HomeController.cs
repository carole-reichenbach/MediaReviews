
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
            
            // create 5 reviews
            ReviewInformation review1 = new ReviewInformation{Type = "Book", Name = "fifty shades of grey", WhenReviewed = new DateTime(2012,08,19), Rating = 3, Review = "i loved it"};
            ReviewInformation review2 = new ReviewInformation{Type = "song", Name = "love song for no one", WhenReviewed = new DateTime(2012,08,19), Rating = 3, Review = "i loved it"};
            ReviewInformation review3 = new ReviewInformation{Type = "movie", Name = "titanic", WhenReviewed = new DateTime(2012,08,19), Rating = 3, Review = "i loved it"};

            var reviewsList = new List<ReviewInformation>();
            reviewsList.Add(review1);
            reviewsList.Add(review2);
            reviewsList.Add(review3);

            data.RecentReviews = reviewsList;

            return View(data);
        }
    }

    public class WelcomeData
    {
        public IEnumerable<ReviewInformation> RecentReviews { get; set; }
    }

    public class ReviewInformation
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public DateTime WhenReviewed { get; set; }

        public int Rating { get; set; }

        public string Review { get; set; }
    }
}

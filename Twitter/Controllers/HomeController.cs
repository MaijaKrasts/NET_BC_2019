using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twitter.Models;
using TwitterLogic;

namespace Twitter.Controllers
{
    public class HomeController : Controller
    {
        private TweetManager _tweets;

        public HomeController(TweetManager tweetManager)
        {
            _tweets = tweetManager;

        }
        public IActionResult Index()
        {
            //TweetModel model = new TweetModel();
            //model.TweetsList = _tweets.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Index(TweetModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    var tweet = new GeoTwitterDataEntry()
            //    {
            //        TweetCreationDateTimeUtc = DateTime.Now,
            //        TweetText = model.Text,
            //        //   Author = HttpContext.Session.GetUserEmail(),
            //    };
            //    _tweets.Create(tweet);
            //    return RedirectToAction("About", "Home");
            //}

            //// kategorijas nepieciešams atlasīt arī POST pieprasījumā
            //model.TweetsList= _tweets.GetAll();
            return View(model);
            // return RedirectToAction("Index", "Home");

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

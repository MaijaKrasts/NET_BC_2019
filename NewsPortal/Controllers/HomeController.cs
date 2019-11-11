using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Models;
using NewsPortalLogic;

namespace NewsPortal.Controllers
{
    public class HomeController : Controller
    {
        private NewsManager _news;

        public HomeController(NewsManager newsManager)
        {
            _news = newsManager;
        }

        public IActionResult Index(int? id)
        {
            var view = _news.GetAll();
            return View(view);
        }

        public IActionResult About()
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortalLogic;

namespace NewsPortal.Controllers
{
    public class NewsController : Controller
    {
        private NewsManager _news;

        public NewsController(NewsManager newsManager)
        {
            _news = newsManager;
        }

           public IActionResult Index(int id)
        {
            var single = _news.Get(id);
            return View(single);
        }
    }
}
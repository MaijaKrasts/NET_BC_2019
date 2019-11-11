using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Models;
using NewsPortalLogic;

namespace NewsPortal.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager _categories;
        private NewsManager _news;

        public CategoryController(CategoryManager categoryManager, NewsManager newsManager)
        {
            _categories = categoryManager;
            _news = newsManager;
        }

        public IActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                var news = _news.GetByCategory(id.Value).ToList();
                var categories = _categories.GetAll().ToList();
                var category = _categories.Get(id.Value);

                NewsModel model = new NewsModel()
                {
                    News = news,
                    Categories = categories,
                    SingleCat = category
                };

                return View(model);
            }

            else
            {
                var news = _news.GetByCategory(1).ToList();
                var categories = _categories.GetAll().ToList();
                var category = _categories.Get(1);

                NewsModel model = new NewsModel()
                {
                    News = news,
                    Categories = categories,
                    SingleCat = category
                };

                return View(model);
            }
            

        }
    }
}
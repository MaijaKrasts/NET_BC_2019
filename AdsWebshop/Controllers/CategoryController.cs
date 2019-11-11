using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdsWebshop.Logic;
using AdsWebshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdsWebshop.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager _categories;
        private AdManager _ads;

        public CategoryController(CategoryManager categoryManager, AdManager adManager)
        {
            _categories = categoryManager;
            _ads = adManager;
        }

        public IActionResult Index()
        {
            var categories = _categories.GetAll();

            foreach (var cat in categories)
            {
                // atlasa un uzstāda preču skaitu zem konkrētās kategorijas
                cat.AdCount = _ads.GetByCategory(cat.Id).Count;
            }

            var model = new CategoryModel()
            {
                Categories = categories
            };

            return View(model);
        }
    }   
}
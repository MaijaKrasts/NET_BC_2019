using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdsWebshop.Logic;
using AdsWebshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdsWebshop.Controllers
{
    public class AdController : Controller
    {
        private CategoryManager _categories;
        private AdManager _ads;

        public AdController(CategoryManager categoryManager, AdManager adManager)
        {
            _categories = categoryManager;
            _ads = adManager;
        }
        public IActionResult Category(int id)
        {
            CategoryModel model = new CategoryModel();
            model.Categories = _categories.GetAll();
            model.Category = _categories.Get(id);
            model.Ads = _ads.GetByCategory(id);

            return View(model);
        }

        public IActionResult SingleAd(int id)
        {
            CategoryModel model = new CategoryModel();
            model.Categories = _categories.GetAll();
            model.Ad = _ads.Get(id);
            //model.Category = _categories.Get(id);

            return View(model);
        }

        public IActionResult Create()
        {
            AdModel model = new AdModel();

            model.Email = HttpContext.Session.GetUserEmail(); 

            model.Categories = _categories.GetAll();

            return View(model);
        }

        [HttpPost]

        public IActionResult Create(AdModel model)
        {
            if(ModelState.IsValid)
            {
                // string title, decimal price, string location, string descritpion, string email, string phone

                var ad = new Ad()
                {
                    CategoryId = model.CategoryId,
                    CreatedOn = DateTime.Now,
                    Description = model.Description,
                    Email = model.Email,
                    Location = model.Location,
                    Price = model.Price,
                    Telephone = model.Phone,
                    Title = model.Title,
                    Photo = model.Photo
                };

                _ads.Create(ad);

                // ja viss OK, pārsūtām uz sludinājumu sadaļu
                return RedirectToAction(nameof(MyAds), new { id = model.CategoryId });
            }

            // kategorijas nepieciešams atlasīt arī POST pieprasījumā
            model.Categories = _categories.GetAll();
            return View(model);

        }

        public IActionResult MyAds()
        {
            var ads = _ads.GetByUser(HttpContext.Session.GetUserEmail());

            //string useremail = HttpContext.Session.GetUserEmail();
            //List<Ad> ads = new List<Ad>();

            //var myads = _ads.GetAll().Where(e => useremail == _ads.Table.Email);
            //int id = myads.GetUserId();

            //foreach (var ad in myads)
            //{
            //   ads.Add(_ads.Get(id));
            //}

            return View(ads);
        }
    }
}
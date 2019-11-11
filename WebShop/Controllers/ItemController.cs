using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webshop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ItemController : Controller
    {
        private CategoryManager _categories;
        private ItemManager _items;

        public ItemController(CategoryManager categoryManager, ItemManager itemManager)
        {
            _categories = categoryManager;
            _items = itemManager;
        }
        public IActionResult Index(int id)
        {
            _categories.SeedCategory();
            var items = _items.GetByCategory(id);
            var categories = _categories.GetAll();

            foreach (var cat in categories)
            {
                // atlasa un uzstāda preču skaitu zem konkrētās kategorijas
                cat.ItemCount = _items.GetByCategory(cat.Id).Count;
            }

            var model = new CatalogModel()
            {
                Items = items,
                Categories = categories,
            };

            return View(model);
        }

        public IActionResult Buy (int id)
        {
            var item = _items.Get(id);

            var basket = HttpContext.Session.GetUserBasket();
            
            if (basket==null)
            {
                basket = new List<int>();
            }

            basket.Add(id);

            HttpContext.Session.SetUserBasket(basket);

            return RedirectToAction("Index", "Item", new { id = item.CategoryId });
        }

        public IActionResult Delete(int id)
        {
            // 1. dzēst preci no groza

            var basket = HttpContext.Session.GetUserBasket();
            basket.Remove(id);

            // 2. atjaunot dauts sesijā

            HttpContext.Session.SetUserBasket(basket);

            return RedirectToAction("Basket");
        }

        public IActionResult Basket()
        {
            
            var basket = HttpContext.Session.GetUserBasket();

            List<Item> basketItems = new List<Item>();

            if (basket != null)
            {
                foreach (var id in basket)
                {
                    basketItems.Add(_items.Get(id));
                    
                }
            }

            return View(basketItems);

        }
    }
}
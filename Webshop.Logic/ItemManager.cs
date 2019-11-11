using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Webshop.Logic
{
    public class ItemManager : BaseManager<Item>
    {
        public ItemManager(WebShopDB db)
            :base(db)
        {

        }

        protected override DbSet<Item> Table
        {
            get
            {
                return _db.Items;
            }
        }

        public List<Item> GetByCategory(int categoryId)
        {

            List<Item> categoryItems = _db.Items.Where(u => u.CategoryId == categoryId).ToList();
            return categoryItems;
        }

        //public Item Create(Item item)
        //{
        //    _db.Items.Add(item);
        //    _db.SaveChanges();
        //    return item;            
        //}

       // public void Update(Item item)
       // {
       //     var currentItem = _db.Items.FirstOrDefault(u => u.Id == item.Id);
       //     currentItem.Price = item.Price;
       //     currentItem.Description = item.Description;
       //     currentItem.Title = item.Title;
       //     currentItem.Photo = item.Photo;
       //     _db.SaveChanges();
       // }

       // public void Delete(int id)
       // {
       //     var item = _db.Items.FirstOrDefault(u => u.Id == id);
       //     _db.Items.Remove(item);
       //     _db.SaveChanges();
       // }

       //public Item Get(int id)
       // {
       //     var item = _db.Items.FirstOrDefault(u => u.Id == id);
       //     return item;
       // }

        public void SeedItem()
        {
    //        _db.Items.Add(new Item()
    //        {
    //            Id = 1,
    //            Title = "TV LG",
    //            Price = 1000,
    //            Description = "LG 55 inch Class 4K Smart UHD TV w/AI ThinQ® (54.6'' Diag)",
    //            Photo = "https://www.lg.com/us/images/tvs/md06088356/gallery/UM73-D1.jpg",
    //            CategoryId = 13,
    //            TimeAdded = DateTime.Now,
    //            Phone = "+371 29676980",
    //            Email = "davis@davis.lv",
    //            Location = "Talsi"
    //}); 

    //        Items.Add(new Item()
    //        {
    //            Id = 2,
    //            Title = "TV Sony",
    //            Price = 110,
    //            Description = "Sony 108 cm (43 Inches) 4K Ultra HD Certified Android LED TV KD-43X7500F",
    //            Photo = "https://images-na.ssl-images-amazon.com/images/I/81vQQeepz9L._SL1500_.jpg",
    //            CategoryId = 13,
    //            TimeAdded = DateTime.Now,
    //            Phone = "+371 234567898",
    //            Email = "janis@davis.lv",
    //            Location = "Tukums"

    //        }); 

        }
    }
}

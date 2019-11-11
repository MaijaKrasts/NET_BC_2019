using Ads.Webshop.Logic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsWebshop.Logic
{
    public class CategoryManager : BaseManager<Category>
    {

        public CategoryManager(AdsWebShopDB db)
            : base(db)
        {
        }

        protected override DbSet<Category> Table
        {
            get
            {
                return _db.Categories;
            }
        }    

        public void Seed()
        {
            //Categories.Add(new Category()
            //{
            //    Id = 1,
            //    Title = "Elektronika"
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 4,
            //    Title = "Apģērbs"
            //});

            //Categories.Add(new Category()
            //{
            //    Id = 2,
            //    Title = "Tālruņi",
            //    CategoryId = 1
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 3,
            //    Title = "Televizori",
            //    CategoryId = 1
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 5,
            //    Title = "Vīriešu",
            //    CategoryId = 4
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 6,
            //    Title = "Sieviešu",
            //    CategoryId = 4
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 7,
            //    Title = "Bērnu",
            //    CategoryId = 4
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 8,
            //    Title = "Velosipēdi"
            //});
            //Categories.Add(new Category()
            //{
            //    Id = 9,
            //    Title = "Automašīnas"
            //});
        }
    }
}

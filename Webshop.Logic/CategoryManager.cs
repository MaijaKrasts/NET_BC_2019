using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Webshop.Logic
{
    public class CategoryManager : BaseManager<Category>
    {

        public CategoryManager(WebShopDB db)
            :base(db)
        {
        }

        protected override DbSet<Category> Table
        {
            get
            {
                return _db.Categories;
            }
        }

        // izdzēst:
        //public List<Category> GetAll()
        //{
        //    return _db.Categories.ToList();
        //}

        //public Category Get(int id)
        //{
        //    var category = _db.Categories.FirstOrDefault(u => u.Id == id);
        //    return category;
        //}

        public void SeedCategory()
        {

        }

    }
}

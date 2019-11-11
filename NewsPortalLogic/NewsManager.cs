using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPortalLogic
{
    public class NewsManager
    {
        protected NewsPortalDB _db;

        public NewsManager(NewsPortalDB db)
        {
            _db = db;
        }

        public News Get(int id)
        {
            return _db.NEWS.FirstOrDefault(i => i.Id == id);
        }
        public List<News> GetAll()
        {
            return _db.NEWS
                .OrderByDescending(i => i.CreatedOn)
                .Take(10)
                .ToList();
        }
        public List<News> GetByCategory(int categoryId)
        {
            var news = _db.NEWS
                .Where(i => i.CategoryId == categoryId)
                .OrderByDescending(i=>i.CreatedOn)
                .Take(10)
                .ToList();

            return news;
        }
    }
}

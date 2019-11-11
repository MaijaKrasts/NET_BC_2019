using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPortalLogic
{
    public class CategoryManager
    {
        protected NewsPortalDB _db;

        public CategoryManager(NewsPortalDB db)
        {
            _db = db;
        }

        public Category Get(int id)
        {
            return _db.CATEGORIES.FirstOrDefault(i => i.Id == id);
        }

        public List<Category> GetAll()
        {
            return _db.CATEGORIES.ToList();
        }
    }
}

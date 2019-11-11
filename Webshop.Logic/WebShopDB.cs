using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Logic
{
   public class WebShopDB: DbContext 
    {
        public WebShopDB(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }

        internal object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
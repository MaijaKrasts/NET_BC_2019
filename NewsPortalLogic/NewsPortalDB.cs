using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortalLogic
{
    public class NewsPortalDB : DbContext
    {
        public NewsPortalDB (DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> CATEGORIES { get; set; }
        public DbSet<News> NEWS { get; set; }
    }
}

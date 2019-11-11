using AdsWebshop.Logic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.Webshop.Logic
{
        public class AdsWebShopDB : DbContext
        {
            public AdsWebShopDB (DbContextOptions options) : base(options)
            {

            }

            public DbSet<Category> Categories { get; set; }
            public DbSet<Ad> Ads { get; set; }
            public DbSet<User> Users { get; set; }
        }
    }

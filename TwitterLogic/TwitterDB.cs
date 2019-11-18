using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterLogic
{
    public class TwitterDB : DbContext
    {
      public TwitterDB(DbContextOptions<TwitterDB> options)
                : base(options)
            {

            }

        public DbSet<GeoTwitterDataEntry> TweetsList { get; set; }
        public DbSet<Answer> Answers { get; set; }

        //public TwitterDB(DbContextOptions options) : base(options)
        //{ }
        //public DbSet<Tweet> Tweets { get; set; }
    }
}


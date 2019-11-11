using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdsWebshop.Logic;

namespace AdsWebshop.Models
{
    public class CategoryModel
    {
            public List<Ad> Ads{ get; set; }
            public List<Category> Categories { get; set; }
            public Category Category { get; set; }
            public Ad Ad { get; set; }

    }
}

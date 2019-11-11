﻿using NewsPortalLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Models
{
    public class NewsModel
    {
        public List<Category> Categories { get; set; }
        public Category SingleCat { get; set; }
        public List<News> News { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsWebshop.Logic
{
        public class Ad
        {
            public int Id { get; set; }
            public decimal Price { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Photo { get; set; }
            public int CategoryId { get; set; }
            public string Location { get; set; }
            public DateTime CreatedOn { get; set; }
            public string Telephone { get; set; }
            public string Email { get; set; }
        }
    }

using Ads.Webshop.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsWebshop.Logic
{
    public class Category : BaseData
    {
        public string Title { get; set; }
        public int? CategoryId { get; set; }

        [NotMapped]
        public int AdCount { get; set; }
    }
}

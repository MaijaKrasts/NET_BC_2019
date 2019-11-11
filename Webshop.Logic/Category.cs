using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Logic
{
    public class Category : BaseData
    {
        public string Title { get; set; }
        public  int? CategoryId { get; set; }
        
        //virtuāla kolona, nav jāmeklē datubāzē
        [NotMapped]
        public int ItemCount { get; set; }
    }
}

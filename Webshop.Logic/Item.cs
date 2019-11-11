using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Logic
{
    public class Item : BaseData
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Title{ get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }

        //public DateTime TimeAdded { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
        //public string Location { get; set; }
    }
}

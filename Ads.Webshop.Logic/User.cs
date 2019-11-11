using Ads.Webshop.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsWebshop.Logic
{
    public class User : BaseData
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

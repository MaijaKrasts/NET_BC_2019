using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TwitterLogic;

namespace Twitter.Models
{
    public class TweetModel
    {
        public List<GeoTwitterDataEntry> TweetsList {get;set;}

        [Required]
        public string Text { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TwitterLogic
{
    [Table("TweetsTable")]
    public class GeoTwitterDataEntry
    {
        [Key]
        public Guid TweetKeyGuid { get; set; }
        public DateTime TweetCreationDateTimeUtc { get; set; }
        [MaxLength(160)]
        public string TweetText { get; set; }
    }
    //public class Tweet
    //{
    //    public int Id { get; set; }
    //    public string Text { get; set; }
    //    public string Author { get; set; }
    //    public DateTime CreatedOn { get; set; }
    //}
}

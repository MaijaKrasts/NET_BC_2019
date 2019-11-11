using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortalLogic
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text{ get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
        public string Author { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

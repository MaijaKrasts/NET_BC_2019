using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AdsWebshop.Logic;

namespace AdsWebshop.Models
{
    public class AdModel
    {
        public int Id { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }

        public string Photo { get; set; }
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public List<Category> Categories{get; set;}
    }
}

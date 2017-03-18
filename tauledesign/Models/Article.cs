using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tauledesign.Models
{
    public class Article
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Kategori")]
        public string Category { get; set; }

        public int? Ordinal { get; set; }
    }
}
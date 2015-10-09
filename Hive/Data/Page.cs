using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class Page
    {
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }

        [Display(Name = "Https")]
        public bool IsHttps { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
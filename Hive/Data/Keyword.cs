using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class Keyword
    {
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(150)]
        public string Phrase { get; set; }

        public DateTime DateAdded { get; set; }



    }
}
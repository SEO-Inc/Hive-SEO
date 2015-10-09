using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class State
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [Display(Name = "State")]
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
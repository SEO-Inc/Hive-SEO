using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class Country
    {
        private ICollection<State> _states;

        public Country()
        {
            _states = new List<State>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        [Display(Name = "Country")]
        public string Name { get; set; }

        public bool Active { get; set; }

        public ICollection<State> States {
            get { return _states; }
            set { _states = value; } 
        }

    }
}
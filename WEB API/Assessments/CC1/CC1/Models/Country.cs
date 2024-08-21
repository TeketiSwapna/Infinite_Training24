using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CC1.Models
{
    public class Country
    {
        //[Key]
        public int ID { get; set; }
        public string CountryName { get; set; }
        public string Capital { get; set; }
    }
}
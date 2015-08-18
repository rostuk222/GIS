using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelericGis.Models
{
    public class StreetRadiation
    {
        public int ID { get; set; }
        public int Radiation { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Extensions { get; set; }
    }
}
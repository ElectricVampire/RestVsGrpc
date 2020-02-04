using System;
using System.Collections.Generic;
using System.Text;

namespace Meteorite.Models
{
    public class MeteoriteLanding
    {
        public string Fall { get; set; }
        public GeoLocation GeoLocation { get; set; }
        public int ID { get; set; }
        public double Mass { get; set; }
        public string Name { get; set; }
        public string NameType { get; set; }
        public string RecClass { get; set; }
        public double RecLAT { get; set; }
        public double RecLONG { get; set; }
        public DateTime Year { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD.Entities
{
    public class Location
    {
        public Location()
        {
            this.Country = "";
            this.State = "";
            this.City = "";
            this.ZipCode = "";
        }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}

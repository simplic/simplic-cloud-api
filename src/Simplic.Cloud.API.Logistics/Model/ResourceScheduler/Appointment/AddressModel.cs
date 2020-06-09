using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class AddressModel
    {
        public Guid AddressId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNr { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string CountryIso { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

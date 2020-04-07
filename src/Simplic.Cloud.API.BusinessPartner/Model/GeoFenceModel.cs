using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.BusinessPartner
{
    public class GeoFenceModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<GeoLocationModel> Points { get; set; } = new List<GeoLocationModel>();
    }
}

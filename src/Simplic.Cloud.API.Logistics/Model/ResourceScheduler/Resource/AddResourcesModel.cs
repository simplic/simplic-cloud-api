using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class AddResourcesModel
    {
        public IList<DriverResourceModel> Drivers { get; set; } = new List<DriverResourceModel>();
        public IList<TractorUnitResourceModel> TractorUnits { get; set; } = new List<TractorUnitResourceModel>();
        public IList<TrailerResourceModel> Trailer { get; set; } = new List<TrailerResourceModel>();
    }
}

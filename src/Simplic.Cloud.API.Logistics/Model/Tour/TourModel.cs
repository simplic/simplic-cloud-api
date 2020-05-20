using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class TourModel
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Guid Id { get; set; }
        public Guid? DriverId { get; set; }
        public Guid? TractorUnitId { get; set; }
        public Guid? TrailerId { get; set; }
        public IList<TourShipmentModel> Shipments { get; set; } = new List<TourShipmentModel>();
    }
}

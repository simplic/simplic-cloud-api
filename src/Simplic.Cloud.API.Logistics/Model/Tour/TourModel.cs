using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class TourModel
    {
        public Guid Id { get; set; }
        public Guid? DriverId { get; set; }
        public Guid? TractorUnitId { get; set; }
        public Guid? TrailerId { get; set; }
        public bool SyncResourceScheduler { get; set; }
        public IList<Guid> ShipmentIds { get; set; } = new List<Guid>();
    }
}

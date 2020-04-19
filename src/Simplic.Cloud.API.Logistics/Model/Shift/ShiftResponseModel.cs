using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class ShiftResponseModel
    {
        public Guid Id { get; set; }
        public ShiftDriver Driver { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IList<ShiftTour> Tours { get; set; }
    }
}
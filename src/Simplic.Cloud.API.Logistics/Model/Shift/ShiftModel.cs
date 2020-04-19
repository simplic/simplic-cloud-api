using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class ShiftModel
    {
        public Guid Id { get; set; }
        public Guid? DriverId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IList<Guid> TourIds { get; set; }
    }
}

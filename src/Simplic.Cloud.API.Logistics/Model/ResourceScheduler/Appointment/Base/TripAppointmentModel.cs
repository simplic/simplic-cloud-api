using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class TripAppointmentModel : AppointmentBaseModel
    {
        public int DistanceInMeter { get; set; }
        public int TollDistance { get; set; }
        public int RemainingDistanceInMeter { get; set; }
        public int RemainingTollDistance { get; set; }
        public int Toll { get; set; }
    }
}

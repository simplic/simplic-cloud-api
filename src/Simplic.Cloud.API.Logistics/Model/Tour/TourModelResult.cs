using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics
{
    public class TourResponseModel
    {
        public Guid Id { get; set; }
        public TourEmployeeModel Driver { get; set; }
        public TourVehicleModel TractorUnit { get; set; }
        public TourVehicleModel Trailer { get; set; }
        public IList<TourShipmentModel> Shipments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class TourAppointmentModel : TripAppointmentModel
    {
        /// <summary>
        /// Gets or sets the item type list
        /// </summary>
        public IList<ShipmentAppointmentItem> Shipments { get; set; } = new List<ShipmentAppointmentItem>();
    }
}

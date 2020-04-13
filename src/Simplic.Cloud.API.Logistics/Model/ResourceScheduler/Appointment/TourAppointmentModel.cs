using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class TourAppointmentModel : AppointmentBaseModel
    {
        /// <summary>
        /// Gets or sets the item type list
        /// </summary>
        public IList<ShipmentAppointmentItem> Items { get; set; } = new List<ShipmentAppointmentItem>();
    }
}

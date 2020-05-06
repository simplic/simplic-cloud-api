using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class ShipmentAppointmentItem : AppointmentItem
    {
        public string Notes { get; set; }
        public string ExtShipmentNr { get; set; }
        public AddressModel LoadAddress { get; set; }
        public AddressModel UnloadAddress { get; set; }
        public IList<TourShipmentItemModel> Items { get; set; } = new List<TourShipmentItemModel>();
    }
}
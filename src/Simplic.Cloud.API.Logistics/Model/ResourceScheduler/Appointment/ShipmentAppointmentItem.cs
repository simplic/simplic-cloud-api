using System;
using System.Collections.Generic;

namespace Simplic.Cloud.API.Logistics
{
    public class ShipmentAppointmentItem : AppointmentItem
    {
        public string Notes { get; set; }
        public string ExtShipmentNr { get; set; }
        public string LoadNumber { get; set; }
        public string UnloadNumber { get; set; }
        public AddressModel LoadAddress { get; set; }
        public AddressModel UnloadAddress { get; set; }
        public AddressModel CustomerAddress { get; set; }
        public IList<TourShipmentItemModel> Items { get; set; } = new List<TourShipmentItemModel>();
        public Model.AggregatedPriceModel AggregatedPrice { get; set; }
        public ShipmentStatusModel AggregatedStatus { get; set; }
    }
}
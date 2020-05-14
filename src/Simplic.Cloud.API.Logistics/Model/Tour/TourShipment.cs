using System;

namespace Simplic.Cloud.API.Logistics
{
    public class TourShipmentModel
    {
        public Guid Id { get; set; }
        public string ShipmentNr { get; set; }
        public int LoadOrderNumber { get; set; }
        public int UnloadOrderNumber { get; set; }
    }
}
using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Simplic.Cloud.API.BusinessPartner;

namespace Simplic.Cloud.API.Logistics
{
    public class ShipmentModel
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid TransportOrderId { get; set; }

        public IList<ShipmentItemModel> Items { get; set; } = new List<ShipmentItemModel>();
        public string ShipmentNr { get; set; }
        public string ExtShipmentNr { get; set; }
        public string Notes { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? LoadAddressId { get; set; }
        public Guid? DeliveryAddressId { get; set; }

        public DateRangeModel LoadDate { get; set; }
        public DateRangeModel DeliveryDate { get; set; }

        public DateRangeModel ActualLoadDate { get; set; }
        public DateRangeModel ActualDeliveryDate { get; set; }

        public DateRangeModel ScheduledLoadDate { get; set; }
        public DateRangeModel ScheduledDeliveryDate { get; set; }

        public bool IsTemplate { get; set; }
    }
}

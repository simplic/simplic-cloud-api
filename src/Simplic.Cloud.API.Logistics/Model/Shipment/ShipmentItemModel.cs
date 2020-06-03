﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class ShipmentItemModel
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public double Quantity { get; set; }
        public double Weight { get; set; }
        public double SingleCustomerPrice { get; set; }
        public double CalculatedCustomerPrice { get; set; }
        public double SingleCarrierPrice { get; set; }
        public double CalculatedCarrierPrice { get; set; }
        public double SingleSupplierPrice { get; set; }
        public double CalculatedSupplierPrice { get; set; }
        public WeightNoteModel LoadingWeightNote { get; set; }
        public WeightNoteModel DeliveryWeightNote { get; set; }
        public QuantityUnitModel QuantityUnit { get; set; }
    }
}

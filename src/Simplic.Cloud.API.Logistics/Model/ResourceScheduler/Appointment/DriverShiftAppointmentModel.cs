using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class DriverShiftAppointmentModel : AppointmentBaseModel
    {
        /// <summary>
        /// Gets or sets the aggregated sales price
        /// </summary>
        public double AggregatedSalesPrices
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the aggregated margin
        /// </summary>
        public double AggregatedMargin
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Vehicle status request
    /// </summary>
    public class SetVehicleStatusModel : VehicleBaseModel
    {
        /// <summary>
        /// Gets or sets the vehicle status
        /// </summary>
        public VehicleStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the vehicle location
        /// </summary>
        public VehicleLocation Location { get; set; }

        /// <summary>
        /// Gets or sets the current tour id
        /// </summary>
        public Guid? TourId { get; set; }
    }
}

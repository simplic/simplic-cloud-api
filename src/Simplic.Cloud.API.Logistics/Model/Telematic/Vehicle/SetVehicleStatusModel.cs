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
        public VehicleTelematicStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the vehicle location
        /// </summary>
        public VehicleLocationModel Location { get; set; }

        /// <summary>
        /// Gets or sets a list of drivers
        /// </summary>
        public IList<Guid> DriverIds { get; set; } = new List<Guid>();

        /// <summary>
        /// Gets or sets a list of trailers
        /// </summary>
        public IList<Guid> TrailerIds { get; set; } = new List<Guid>();
    }
}

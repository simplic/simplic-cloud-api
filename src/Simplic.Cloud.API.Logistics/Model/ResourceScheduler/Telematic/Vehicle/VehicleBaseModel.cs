using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents the basic vehicle API model
    /// </summary>
    public abstract class VehicleBaseModel
    {
        /// <summary>
        /// Gets or sets the vehicle id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the configuration name
        /// </summary>
        public string ConfigurationName { get; set; }
    }
}

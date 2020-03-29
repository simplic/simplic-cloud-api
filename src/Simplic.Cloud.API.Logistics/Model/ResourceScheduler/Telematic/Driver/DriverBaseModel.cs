using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Driver base model
    /// </summary>
    public class DriverBaseModel
    {
        /// <summary>
        /// Gets or sets the driver id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the configuration name
        /// </summary>
        public string ConfigurationName { get; set; }
    }
}

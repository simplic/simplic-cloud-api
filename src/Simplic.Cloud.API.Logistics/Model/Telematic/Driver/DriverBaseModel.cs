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
        /// Gets or sets the configuration id
        /// </summary>
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets the datetime of the event
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}

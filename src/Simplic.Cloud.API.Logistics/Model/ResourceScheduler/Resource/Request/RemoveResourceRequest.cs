using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Request resources
    /// </summary>
    public class RemoveResourceRequest
    {
        /// <summary>
        /// Gets or sets the resource id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the configuration name
        /// </summary>
        public string ConfigurationName { get; set; }
    }
}

using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Lock resource request
    /// </summary>
    public class LockResourceRequest
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

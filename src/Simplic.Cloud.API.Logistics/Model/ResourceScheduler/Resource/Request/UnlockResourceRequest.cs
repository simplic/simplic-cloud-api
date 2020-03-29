using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Unlock resource request
    /// </summary>
    public class UnlockResourceRequest
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

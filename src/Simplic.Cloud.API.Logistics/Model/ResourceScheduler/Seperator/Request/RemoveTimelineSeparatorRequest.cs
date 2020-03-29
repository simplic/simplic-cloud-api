using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Add timeline Separator requests
    /// </summary>
    public class RemoveTimelineSeparatorRequest
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the configuration name
        /// </summary>
        public string ConfigurationName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Timeline Separator
    /// </summary>
    public class TimelineSeparatorModel
    {
        /// <summary>
        /// Gets or sets the timeline id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the configuration name
        /// </summary>
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Gets or sets the date time
        /// </summary>
        public DateTime Date { get; set; }
    }
}

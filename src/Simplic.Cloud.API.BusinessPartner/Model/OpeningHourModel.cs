using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.BusinessPartner
{
    /// <summary>
    /// Represents an opening hour entry
    /// </summary>
    public class OpeningHourModel
    {
        /// <summary>
        /// Gets or sets the day of week
        /// </summary>
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets the opening timestamp
        /// </summary>
        public TimeSpan Open { get; set; }

        /// <summary>
        /// Gets or sets the close timesampt
        /// </summary>
        public TimeSpan Close { get; set; }
    }
}

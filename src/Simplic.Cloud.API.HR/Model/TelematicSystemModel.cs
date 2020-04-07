using System;

namespace Simplic.Cloud.API.HR
{
    /// <summary>
    /// Represents a telematic system
    /// </summary>
    public class TelematicSystemDocument
    {
        /// <summary>
        /// Gets or sets the telematic provider (spedion, ...)
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the id of the employment in the telematic provider
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the date time from which the telematic system is valid
        /// </summary>
        public DateTime From { get; set; } = new DateTime(2000, 1, 1);

        /// <summary>
        /// Gets or sets the date time until the telematic system is valid
        /// </summary>
        public DateTime? To { get; set; }
    }
}

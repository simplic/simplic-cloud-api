using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents a shift activity
    /// </summary>
    public class ShiftActivityModel
    {
        /// <summary>
        /// Gets or sets the driver status
        /// </summary>
        public DriverStatus Type { get; set; }

        /// <summary>
        /// Gets or sets the start date
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets the end date
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Gets the reamining minutes
        /// </summary>
        public int Remaining { get; set; }

        /// <summary>
        /// Gets or sets whether the appointment is running
        /// </summary>
        public ShiftActivityStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether this are real/none theoretical data
        /// </summary>
        public bool IsTheoretical { get; set; }
    }
}
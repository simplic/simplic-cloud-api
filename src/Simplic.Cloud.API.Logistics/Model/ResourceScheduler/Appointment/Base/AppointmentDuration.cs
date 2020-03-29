using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class AppointmentDuration
    {
        /// <summary>
        /// Gets or sets the trip duration in minutes
        /// </summary>
        public int Trip { get; set; }

        /// <summary>
        /// Gets or sets the remaining trip duration
        /// </summary>
        public int Remaining { get; set; }
    }
}

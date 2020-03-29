using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Distance object
    /// </summary>
    public class AppointmentDistance
    {
        /// <summary>
        /// Gets or ses the trip distance
        /// </summary>
        public int Trip { get; set; }

        /// <summary>
        /// Gets or sets the toll distance
        /// </summary>
        public int Toll { get; set; }

        /// <summary>
        /// Gets or sets tjhe remaining distance
        /// </summary>
        public int Remaining { get; set; }
    }
}

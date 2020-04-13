using System;

namespace Simplic.Cloud.API.Logistics
{
    public class AppointmentItem
    {
        /// <summary>
        /// Gets or sets the appointment item id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the appointment item type
        /// </summary>
        public AppointmentItemType Type { get; set; }
    }
}
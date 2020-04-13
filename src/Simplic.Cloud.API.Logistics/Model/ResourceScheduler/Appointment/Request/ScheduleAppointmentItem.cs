using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents an item within an appointment to schedule
    /// </summary>
    public class ScheduleAppointmentItem
    {
        /// <summary>
        /// Gets or sets the item id. E.g. shipment id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the appointment type
        /// </summary>
        public AppointmentItemType Type { get; set; }
    }
}
using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Remove appointment
    /// </summary>
    public class RemoveAppointmentRequest
    {
        /// <summary>
        /// Gets or sets the appointment id
        /// </summary>
        public Guid Id { get; set; }

        public string ConfigurationName { get; set; } = "default";
    }
}

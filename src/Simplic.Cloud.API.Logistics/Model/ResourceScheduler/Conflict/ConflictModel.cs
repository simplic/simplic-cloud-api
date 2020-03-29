using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Represents a conflict
    /// </summary>
    public class ConflictModel
    {
        /// <summary>
        /// Gets or sets the conflict id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the connected appointment id
        /// </summary>
        public Guid? ConnectedAppointmentId { get; set; }

        /// <summary>
        /// Gets or sets the conflict type
        /// </summary>
        public ConflictType Type { get; set; }

        /// <summary>
        /// Gets or sets the conflict message
        /// </summary>
        public string Message { get; set; }
 
        /// <summary>
        /// Gets or sets the conflict user comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the conflict date
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}
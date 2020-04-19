using System;

namespace Simplic.Cloud.API.Logistics
{
    /// <summary>
    /// Set warning data model
    /// </summary>
    public class SetWarningDataModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the warning id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the appointment id
        /// </summary>
        public Guid AppointmentId { get; set; }

        /// <summary>
        /// Gets or sets the new comment
        /// </summary>
        public string Comment { get; set; }
    }
}

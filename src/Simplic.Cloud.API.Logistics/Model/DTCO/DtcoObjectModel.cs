using System;

namespace Simplic.Cloud.API.Logistics
{
    public abstract class DtcoObjectModel
    {
        /// <summary>
        /// Gets or sets the guid
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Gets or sets the employment id
        /// </summary>
        public Guid EmploymentId { get; set; }

        /// <summary>
        /// Gets or sets the start date
        /// </summary>
        public DateTime StartDate { get; set; }
    }
}

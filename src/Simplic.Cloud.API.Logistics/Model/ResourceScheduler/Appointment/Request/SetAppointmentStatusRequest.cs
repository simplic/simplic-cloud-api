using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplic.Cloud.API.Logistics.Model
{
    /// <summary>
    /// Set appointment status
    /// </summary>
    public class SetAppointmentStatusRequest : BaseModel
    {
        /// <summary>
        /// Gets or sets the appointment id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the date time the status belongs to
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets the appointment status
        /// </summary>
        public AppointmentStatus Status { get; set; }
    }
}

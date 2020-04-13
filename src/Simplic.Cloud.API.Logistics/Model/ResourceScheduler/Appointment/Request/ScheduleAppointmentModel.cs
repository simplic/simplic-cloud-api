using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class ScheduleAppointmentModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the appointment id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the appointment type to schedule
        /// </summary>
        public ScheduleAppointmentType Type { get; set; }

        /// <summary>
        /// Gets or sets the appointment item id
        /// </summary>
        public IList<ScheduleAppointmentItem> Items { get; set; } = new List<ScheduleAppointmentItem>();

        /// <summary>
        /// Gets or sets the attached resource
        /// </summary>
        public IList<Guid> Resources { get; set; } = new List<Guid>();

        /// <summary>
        /// Gets or sets the start datetime
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the start object type 
        /// </summary>
        public DateObjectType StartDateType { get; set; }

        /// <summary>
        /// Gets or sets the end datetime
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the end object type
        /// </summary>
        public DateObjectType EndDateType { get; set; }
    }
}

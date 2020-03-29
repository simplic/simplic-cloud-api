using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class ScheduleAppointmentRequest
    {
        /// <summary>
        /// Gets or sets the appointment id
        /// </summary>
        public Guid Id { get; set; }
        public string ConfigurationName { get; set; } = "default";

        /// <summary>
        /// Gets or sets the appointment type
        /// </summary>
        public AppointmentType Type { get; set; }

        /// <summary>
        /// Gets or sets the attached resource
        /// </summary>
        public IList<Guid> Resources { get; set; }

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

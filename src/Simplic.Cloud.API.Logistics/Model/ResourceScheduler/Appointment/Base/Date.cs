using System;

namespace Simplic.Cloud.API.Logistics
{
    public class DateObject
    {
        public DateTime ScheduledDate { get; set; }
        public DateTime PlannedDate { get; set; }
        public DateTime? ActualDate { get; set; }

        /// <summary>
        /// Gets or sets the date object time type
        /// </summary>
        public DateObjectType Type { get; set; }
    }
}

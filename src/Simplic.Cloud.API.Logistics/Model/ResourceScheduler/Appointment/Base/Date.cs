using System;
using System.Collections.Generic;
using System.Text;

namespace Simplic.Cloud.API.Logistics
{
    public class DateObject
    {
        public DateTime Date { get; set; }
        public DateTime PlannedDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public DateTime CurrentDate { get; set; }

        public TimeSpan Time { get; set; }
        public TimeSpan PlannedTime { get; set; }
        public TimeSpan? ActualTime { get; set; }
        public TimeSpan CurrentTime { get; set; }

        /// <summary>
        /// Gets or sets the date object time type
        /// </summary>
        public DateObjectType Type { get; set; }
    }
}

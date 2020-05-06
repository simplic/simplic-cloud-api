using System;

namespace Simplic.Cloud.API.Logistics
{
    public class DtcoWeekRestActivityInfoModel : DtcoObjectModel
    {
        /// <summary>
        /// Gets or sets the weekly rest time id
        /// </summary>
        public Guid WeeklyRestTimeId { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the start date time
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets the end date time
        /// </summary>
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// Gets or sets the duration
        /// </summary>
        public DtcoDateModel Duration { get; set; }
    }
}

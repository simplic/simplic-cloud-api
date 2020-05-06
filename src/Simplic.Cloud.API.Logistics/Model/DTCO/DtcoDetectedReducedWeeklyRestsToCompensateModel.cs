using System;

namespace Simplic.Cloud.API.Logistics
{
    public class DtcoDetectedReducedWeeklyRestsToCompensateModel : DtcoObjectModel
    {
        /// <summary>
        /// Gets or sets the weekly rest time id
        /// </summary>
        public Guid WeeklyRestTiemId { get; set; }

        /// <summary>
        /// Gets or sets the analysis timestamp
        /// </summary>
        public DateTime AnalysisTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the end time
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the expiration
        /// </summary>
        public DateTime Expiration { get; set; }

        /// <summary>
        /// Gets or sets the duration
        /// </summary>
        public DtcoDateModel Duration { get; set; }

        /// <summary>
        /// Gets or sets the time to compensate
        /// </summary>
        public DtcoDateModel TimeToCompensate { get; set; }
    }
}

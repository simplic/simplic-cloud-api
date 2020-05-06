using System;

namespace Simplic.Cloud.API.Logistics
{
    public class DtcoDailyDrivingTimeModel : DtcoObjectModel
    {
        /// <summary>
        /// Gets or sets the analysis timestamp
        /// </summary>
        public DateTime AnalysisTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the number of used extended driving durations
        /// </summary>
        public int NrOfUsedExtendedDrivingDurations { get; set; }

        /// <summary>
        /// Gets or sets the number of allowed extended driving durations
        /// </summary>
        public int NrOfAllowedExtendedDrivingDurationsPerWeek { get; set; }

        /// <summary>
        /// Gets or sets the current duration
        /// </summary>
        public DtcoDateModel CurrentDuration { get; set; }

        /// <summary>
        /// Gets or sets the remaining duration
        /// </summary>
        public DtcoDateModel RemainingDuration { get; set; }

        /// <summary>
        /// Gets or sets the max allowed duration
        /// </summary>
        public DtcoDateModel MaxAllowedDuration { get; set; }
    }
}

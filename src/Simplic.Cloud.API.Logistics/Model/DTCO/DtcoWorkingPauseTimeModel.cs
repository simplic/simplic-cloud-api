using System;

namespace Simplic.Cloud.API.Logistics
{
    public class DtcoWorkingPauseTimeModel : DtcoObjectModel
    {
        /// <summary>
        /// Gets or sets the analysis timestamp
        /// </summary>
        public DateTime AnalysisTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the working duration since working start
        /// </summary>
        public DtcoDateModel WorkingDurationSinceWorkingStart { get; set; }

        /// <summary>
        /// Gets or sets the pause duration since working starts 
        /// </summary>
        public DtcoDateModel PauseDurationSinceWorkingStart { get; set; }

        /// <summary>
        /// Gets or sets the needed pause time until end of work
        /// </summary>
        public DtcoDateModel NeededPauseTimeUntilEndOfWork { get; set; }

        /// <summary>
        /// Gets or sets the min duration of next rest
        /// </summary>
        public DtcoDateModel MinDurationOfNextRest { get; set; }

        /// <summary>
        /// Gets or sets the current rest duration
        /// </summary>
        public DtcoDateModel CurrentRestDuration { get; set; }

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

using System;

namespace Simplic.Cloud.API.Logistics
{
    public class DtcoDrivingPauseTimeModel : DtcoObjectModel
    {
        /// <summary>
        /// Gets or sets the analysis timestamp
        /// </summary>
        public DateTime AnalysisTimestamp { get; set; }

        /// <summary>
        ///  Gets or sets wherther the pause was splited
        /// </summary>
        public bool WasSplitedPause { get; set; }

        /// <summary>
        /// Gets or sets the minimum duration of the next rest
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

using System;

namespace Simplic.Cloud.API.Logistics
{
    public class DtcoDailyRestForDrivingTimeModel : DtcoObjectModel
    {
        /// <summary>
        /// Gets or sets the analysis date
        /// </summary>
        public DateTime AnalysisTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the max end time without normal rest
        /// </summary>
        public DateTime MaxEndTimeWithNormalRest { get; set; }

        /// <summary>
        /// Gets or sets the max end time with reduced rest
        /// </summary>
        public DateTime MaxEndTimeWithReducedRest { get; set; }

        /// <summary>
        /// Gets or seth whether the next rest is reduced
        /// </summary>
        public bool IsNextRestReduced { get; set; }

        /// <summary>
        /// Gets or sets whether the multiple driver mode is active
        /// </summary>
        public bool IsMultipleDriverModeActive { get; set; }

        /// <summary>
        /// Gets or sets whether the first part of split is already done
        /// </summary>
        public bool IsFirstPartOfSplitAlreadyDone { get; set; }

        /// <summary>
        /// Gets or sets the number of used reduced rest times
        /// </summary>
        public int NrOfUsedReducedResttimes { get; set; }

        /// <summary>
        /// Gets or sets the number of allowed reduced rest times
        /// </summary>
        public int NrOfAllowedReducedResttimes { get; set; }

        /// <summary>
        /// Gets or sets the minimum duration of the next rest
        /// </summary>
        public DtcoDateModel MinDurationOfNextRest { get; set; }

        /// <summary>
        /// Gest or sets the current rest duration
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
